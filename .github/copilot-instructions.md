# Copilot Instructions for Aspire Imposter Game

## Project Overview

This is a Progressive Web App (PWA) built with .NET 10 and Blazor WebAssembly. The game runs entirely client-side and is designed to be deployed to Azure Static Web Apps and installable on iOS devices.

**Game Type**: Imposter game with word-guessing mechanics across various themed word banks.

## Technology Stack

- **Framework**: .NET 10, Blazor WebAssembly
- **Language**: C# with nullable reference types enabled
- **Deployment**: Azure Static Web Apps
- **PWA Features**: Service Worker, offline support, installable on iOS
- **Project Type**: Single-page application (SPA) with client-side only logic

## Build and Development Commands

### Prerequisites
- .NET 10 SDK or later

### Build Commands
```bash
# Restore dependencies
dotnet restore

# Build the solution
dotnet build

# Run locally for development
cd ImposterGame
dotnet run
```

### Publishing
```bash
# Publish for release (Azure Static Web Apps)
cd ImposterGame
dotnet publish -c Release -o ../publish
```

The published output in `publish/wwwroot` contains all static files for deployment.

### Testing
Currently, there are no automated tests in this repository. When adding tests:
- Place test projects in the repository root
- Follow .NET testing conventions using xUnit, NUnit, or MSTest
- Name test projects with `.Tests` suffix (e.g., `ImposterGame.Tests`)

## Project Structure

```
aspire-imposter-game/
├── ImposterGame/              # Main Blazor WebAssembly PWA project
│   ├── Pages/                 # Razor pages/components
│   ├── Services/              # Application services (e.g., WordBankService)
│   ├── Layout/                # Layout components
│   ├── wwwroot/              # Static assets (PWA manifest, service worker, icons)
│   └── ImposterGame.csproj
└── AspireImposterGame.sln
```

## Coding Conventions

### General Guidelines
- **C# Version**: Use C# 12+ features available in .NET 10
- **Nullable Reference Types**: Enabled - always handle null cases appropriately
- **Implicit Usings**: Enabled - common namespaces are automatically imported

### Naming Conventions
- Use PascalCase for classes, methods, properties, and public fields
- Use camelCase for private fields with underscore prefix (e.g., `_wordBanks`)
- Use meaningful, descriptive names

### Code Organization
- Place services in the `Services` namespace
- Place Razor components in the `Pages` namespace
- Keep business logic in services, not in Razor components

### Blazor-Specific
- Use proper component lifecycle methods (`OnInitialized`, `OnParametersSet`, etc.)
- Follow Blazor component parameter patterns with `[Parameter]` attributes
- Use `StateHasChanged()` when necessary to trigger UI updates

## PWA-Specific Considerations

### Service Worker
- Service worker files are in `wwwroot/service-worker.js` and `wwwroot/service-worker.published.js`
- Changes to cached assets require service worker updates
- Test offline functionality after making changes to static assets

### iOS Compatibility
- Ensure meta tags in `index.html` remain compatible with iOS
- Test PWA installation flow on iOS devices
- Icons must be properly sized (192x192, 512x512)

### Manifest
- PWA manifest is at `wwwroot/manifest.webmanifest`
- Update manifest when changing app name, icons, or theme colors

## Game-Specific Features

### Word Bank Service
- Located at `Services/WordBankService.cs`
- Contains themed word banks: Technology, Animals, People, Sports, Old Testament, New Testament, Jesus, The Flood, Revelation, Broadway Musicals
- When adding new themes:
  - Add to the `_wordBanks` dictionary
  - Include at least 30-50 words per theme
  - Use descriptive, recognizable words appropriate for the theme
  - Alphabetically order theme names for consistency

### Game Mechanics
- The game is an "imposter" style game where players guess words
- Client-side only - no server-side game state or multiplayer (yet)
- Random word selection from themed word banks

## Deployment and CI/CD

### Azure Static Web Apps
- Deployment workflow: `.github/workflows/azure-static-web-apps-proud-bay-0d59c0410.yml`
- Triggers on push/PR to `master` branch
- Uses .NET 10 in the build pipeline
- Deploys from `publish/wwwroot` directory

### Workflow Notes
- Build runs `dotnet restore` and `dotnet publish -c Release`
- No API or backend build required (client-side only)
- Static Web Apps configuration in `wwwroot/staticwebapp.config.json`

## Future Enhancements

The following features are planned but not yet implemented:
- Multiplayer functionality with SignalR
- Game lobby system
- Chat features
- Game rooms
- Player authentication
- Leaderboards

When implementing these features, they will require backend services and architectural changes from pure client-side to client-server model.

## Common Tasks

### Adding a New Word Theme
1. Edit `Services/WordBankService.cs`
2. Add a new key-value pair to the `_wordBanks` dictionary
3. Include 30-50 relevant words for the theme
4. Test locally with `dotnet run`
5. Ensure the theme appears in the theme selection UI

### Adding a New Page/Component
1. Create `.razor` file in `Pages/` directory
2. Add proper `@page` directive for routing
3. Include necessary `@using` statements or rely on `_Imports.razor`
4. Test navigation and component rendering

### Modifying Styles
- Global styles are in `wwwroot/css/`
- Component-specific styles can be in `.razor.css` files
- Maintain mobile-first responsive design

## Security Considerations

- This is a client-side only application with no authentication currently
- Any secrets or sensitive data must never be committed to the repository
- When adding backend features, implement proper authentication and authorization
- Validate all user inputs before processing

## Best Practices for Contributing

1. **Small, Focused Changes**: Make minimal modifications to achieve the goal
2. **Test Locally**: Always test changes with `dotnet run` before committing
3. **Build Before Committing**: Ensure `dotnet build` succeeds
4. **Preserve PWA Functionality**: Test offline mode and installability after changes
5. **Document New Features**: Update this file and README.md for significant changes
6. **Follow Existing Patterns**: Match the coding style and structure of existing code
