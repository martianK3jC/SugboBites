# Sugbo Bites

Sugbo Bites is a responsive Cebu food guide built with Blazor. It introduces local dishes, links readers to selected tourism and restaurant sources, and lets visitors collect dishes in a personal food trail for their current visit.

## Features

- Home page featuring Cebu dishes, food destinations, and source-linked restaurant notes.
- Searchable and filterable dish guide with individual detail pages.
- Food trail for saving and removing dishes while exploring.
- Responsive layouts for desktop, tablet, and mobile, with keyboard focus and reduced-motion support.
- Local food photography served from `wwwroot/images`.
- Source links for destination and restaurant information. Venue menus, hours, and prices are not presented as verified live data.

The food guide is editorial content stored in `FoodGuideService`; the application does not connect to a restaurant, booking, or tourism API. The saved trail is in-memory per Blazor Server circuit and is not retained after a refresh or a new session.

## Tech stack

- .NET 8 / ASP.NET Core Blazor Web App
- Blazor Interactive Server rendering
- C# with nullable reference types enabled
- Tailwind CSS 4.3, built with the Tailwind CLI
- Node.js and npm for the CSS toolchain

## Prerequisites

Install the .NET 8 SDK, Node.js with npm, and Git. No database, API key, or other secret is required for the current implementation.

## Get started

From the `SugboBites` project directory:

```powershell
dotnet restore
npm ci
npm run build:css
dotnet run --launch-profile http
```

Open the URL printed by `dotnet run`. The included `http` launch profile uses `http://localhost:5054`.

To run the app with .NET hot reload while editing:

```powershell
dotnet watch --project .\SugboBites.csproj run --launch-profile http
```

To rebuild the CSS after editing styles or Razor markup:

```powershell
npm run build:css
```

For continuous CSS rebuilding, run this in a separate terminal:

```powershell
npm run watch:css
```

## Build and tests

Build the .NET application:

```powershell
dotnet build
```

There is currently no automated test project in this repository. `dotnet test` therefore has no application test suite to run.

## Configuration

The application uses the standard `appsettings.json` and `appsettings.Development.json` files for logging and host configuration. The current files contain no credentials, and the app does not require environment secrets. Keep future local overrides in files such as `appsettings.Local.json` or `appsettings.Development.local.json`, or configure environment variables. If the app later needs development secrets, configure a User Secrets ID before using .NET User Secrets. Those local files and common secret formats are excluded by `.gitignore`.

## Routes

| Route | Description |
| --- | --- |
| `/` | Food guide landing page |
| `/explore` | Search and filter Cebu dish entries |
| `/food/{id}` | Dish detail and source links |
| `/trail` | Saved dishes for the current visit |

## Screenshots

No screenshots are currently included. Add captures of the home, Explore, dish detail, and food trail pages under `docs/screenshots/` and link them here when available.

## Content and attribution

Dish and destination information is editorial and links to source pages, including the [Cebu Provincial Tourism Office](https://tourism.cebu.gov.ph/), [Carcar City tourism](https://tourism.cebu.gov.ph/explore/carcar-city/), and relevant [MICHELIN Guide Cebu listings](https://guide.michelin.com/ph/en/central-visayas/cebu-city_2340421/restaurants). Restaurant details can change; consult the linked listing or venue before visiting. Photos are local project assets; verify their usage rights before redistributing the site publicly.

