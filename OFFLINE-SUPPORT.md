# Offline Support Documentation

## Overview

This PWA has been configured to work fully offline with infinite cache duration. Once the app is loaded and cached, it will continue to work without any network connection, including in airplane mode on iOS devices.

## Key Features

### 1. Cache-First Strategy
The service worker implements a cache-first strategy:
- All requests first check the cache
- Only if not cached, it attempts a network request
- Network failures gracefully fall back to cached content
- Successfully fetched resources are cached for future offline use

### 2. Immediate Activation
- `skipWaiting()` ensures new service workers activate immediately
- `clients.claim()` takes control of all pages immediately
- Updates are applied without requiring page refreshes

### 3. Complete Asset Caching
The service worker caches all required assets including:
- WebAssembly (.wasm) files
- JavaScript (.js) files
- CSS (.css) files
- Images (.png, .jpg, .jpeg, .gif, .ico)
- Fonts (.woff)
- Manifest (.webmanifest)
- Data files (.json)
- DLLs and debugging symbols (.dll, .pdb)

### 4. Infinite Cache Duration
- Caches are version-based using the manifest version
- Old caches are cleaned up, but current cache persists indefinitely
- No time-based expiration is configured
- Cache will persist until:
  - User manually clears browser data
  - App is updated with a new version
  - Browser storage quota is exceeded

## iOS Installation Instructions

### Adding to Home Screen
1. Open Safari on your iPhone
2. Navigate to the deployed URL
3. Tap the Share button (□↑)
4. Scroll down and tap "Add to Home Screen"
5. Name it (default: "Imposter")
6. Tap "Add"

### Running in Airplane Mode
1. Launch the app from your home screen
2. The app will load from cache immediately
3. Enable Airplane Mode
4. The app continues to work fully
5. All game features remain functional

## Technical Implementation

### Service Worker Registration
The service worker is registered with these options:
```javascript
{
  updateViaCache: 'none',  // Always check for updates
  scope: '/'               // Control entire origin
}
```

### Cache Strategy
1. **Install Phase**: Cache all assets from manifest
2. **Activate Phase**: Clean up old caches and take control
3. **Fetch Phase**: 
   - Check cache first
   - Return cached response if available
   - Try network if not cached
   - Cache successful network responses
   - Gracefully handle network failures

### Error Handling
- Navigation requests without cache fall back to index.html
- Failed network requests return 503 Service Unavailable
- All errors are logged to console for debugging

## Testing Offline Functionality

### Method 1: Browser DevTools (Desktop)
1. Open the app in Chrome/Edge
2. Open DevTools (F12)
3. Go to Application > Service Workers
4. Check "Offline" checkbox
5. Refresh the page - app should still work

### Method 2: Network Throttling
1. Open DevTools
2. Go to Network tab
3. Select "Offline" from throttling dropdown
4. Navigate the app - should work normally

### Method 3: iOS Airplane Mode (Production Test)
1. Deploy the app to production
2. Visit and add to home screen
3. Wait for all assets to cache (watch for no loading)
4. Enable Airplane Mode
5. Launch from home screen - should work

## Cache Verification

### Check Cache Status
Open browser console and run:
```javascript
caches.keys().then(keys => console.log('Caches:', keys));
```

### Check Cached Assets
```javascript
caches.open('offline-cache-[version]').then(cache => 
  cache.keys().then(keys => console.log('Cached assets:', keys.length))
);
```

### Clear Cache (for testing)
```javascript
caches.keys().then(keys => 
  Promise.all(keys.map(key => caches.delete(key)))
);
```

## Troubleshooting

### App Not Working Offline
1. Check service worker is registered: 
   - DevTools > Application > Service Workers
   - Should show "Activated and running"

2. Verify cache population:
   - DevTools > Application > Cache Storage
   - Should see "offline-cache-[version]"
   - Should contain ~90+ assets

3. Check for console errors:
   - Open DevTools console
   - Look for service worker or cache errors

### Service Worker Not Installing
1. Ensure HTTPS (required for service workers)
   - Exception: localhost works over HTTP
2. Check for JavaScript errors in service-worker.js
3. Verify service-worker-assets.js exists and is valid

### Updates Not Appearing
1. Service worker caches aggressively
2. Hard refresh: Ctrl+Shift+R (or Cmd+Shift+R on Mac)
3. Clear cache and reload
4. Update check runs every minute automatically

## Best Practices

### For Development
- Use `service-worker.js` (not published version) during development
- Development version fetches from network always
- Use published version for testing offline features

### For Production
- Always test offline mode before releasing
- Verify all assets are in service-worker-assets.js
- Monitor console for service worker errors
- Test on actual iOS device, not just simulator

### For Updates
- Service worker version changes automatically on each build
- Old caches are cleaned up automatically
- Users get updates on next visit (while online)
- Consider showing update notification to users

## Security Considerations

- Service workers only work over HTTPS (except localhost)
- All cached content includes integrity hashes
- Cache-first strategy prevents certain network attacks
- Offline content is isolated by origin

## Performance Benefits

- Near-instant loading after first visit
- Zero network latency for cached resources
- Works in poor network conditions
- Reduces server load
- Better user experience in areas with spotty connectivity

## Limitations

- Initial visit requires network connection
- Updates require network connection
- Storage quota limits (usually several GB)
- iOS Safari may clear cache if storage pressure exists
- Cannot cache external API calls (unless specifically handled)
