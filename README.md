# Aspire Imposter Game

A Progressive Web App (PWA) game built with .NET 10 Blazor WebAssembly and designed to run completely client-side. This application can be side-loaded on an iPhone and deployed to Azure Static Web Apps.

## Features

- ✅ Built with .NET 10 and Blazor WebAssembly
- ✅ Progressive Web App (PWA) with offline support
- ✅ Optimized for iOS devices with proper meta tags and icons
- ✅ Runs entirely client-side after initial load
- ✅ Ready for Azure Static Web Apps deployment
- ✅ Service Worker for caching and offline functionality

## Project Structure

```
aspire-imposter-game/
├── ImposterGame/              # Main Blazor WebAssembly PWA project
│   ├── Pages/                 # Razor pages/components
│   ├── wwwroot/              # Static assets
│   │   ├── manifest.webmanifest    # PWA manifest for iOS/Android
│   │   ├── service-worker.js       # Service worker for offline support
│   │   ├── icon-192.png           # App icon (192x192)
│   │   ├── icon-512.png           # App icon (512x512)
│   │   └── staticwebapp.config.json # Azure Static Web Apps config
│   └── ImposterGame.csproj
└── AspireImposterGame.sln
```

## Prerequisites

- .NET 10 SDK or later
- A modern web browser (Chrome, Edge, Safari, Firefox)
- For deployment: Azure subscription

## Building the Application

```bash
# Restore dependencies
dotnet restore

# Build the solution
dotnet build

# Run locally
cd ImposterGame
dotnet run
```

The application will be available at `http://localhost:5000` (or the port shown in the console).

## Publishing for Azure Static Web Apps

```bash
# Publish for release
cd ImposterGame
dotnet publish -c Release -o ../publish
```

The published output will be in the `publish/wwwroot` directory, which contains all the static files needed for Azure Static Web Apps.

## iOS Installation (Side-loading as PWA)

1. Open Safari on your iPhone
2. Navigate to the deployed URL (e.g., `https://your-app.azurestaticapps.net`)
3. Tap the Share button (square with arrow pointing up)
4. Scroll down and tap "Add to Home Screen"
5. Give it a name and tap "Add"
6. The app will appear on your home screen like a native app

**✈️ Works in Airplane Mode**: Once installed and loaded, the app works completely offline with no network connection. All assets are cached indefinitely.

## PWA Features

### Full Offline Support
The service worker implements a **cache-first strategy** with infinite cache duration:
- All resources are cached on first load
- App works completely offline, even in airplane mode
- No network connection required after initial load
- Cache persists indefinitely until manually cleared or updated
- Gracefully handles network failures

**For detailed information about offline functionality, see [OFFLINE-SUPPORT.md](./OFFLINE-SUPPORT.md)**

### iOS-Specific Optimizations
- `apple-mobile-web-app-capable`: Enables standalone mode
- `apple-mobile-web-app-status-bar-style`: Configures status bar appearance
- `viewport-fit=cover`: Ensures proper display on iPhone X and later with notch
- `apple-touch-icon`: High-quality home screen icons

### Manifest Configuration
The `manifest.webmanifest` file provides:
- App name and description
- Icons for different screen sizes
- Display mode (standalone)
- Theme colors
- Orientation preferences

## Azure Static Web Apps Configuration

The `staticwebapp.config.json` file configures:
- Routing fallback to `index.html` for SPA routing
- MIME types for WebAssembly files
- Cache control headers
- 404 handling

## Development Notes

### .NET 10 and Aspire
This project is built with .NET 10 and follows Aspire architectural patterns for modern cloud-native applications. While traditional Aspire apps use an AppHost for orchestration, this PWA is designed to run entirely client-side, so it doesn't include a separate AppHost project.

### Client-Side Only
All game logic runs in the browser using Blazor WebAssembly. No server-side API is required after the initial download of the app assets.

## Future Enhancements

- [ ] Add multiplayer functionality with SignalR
- [ ] Implement game lobby system
- [ ] Add chat features
- [ ] Create game rooms
- [ ] Add player authentication
- [ ] Implement leaderboards

## License

See LICENSE file for details.

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.
