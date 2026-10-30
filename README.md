# Sugbo Bites

Sugbo Bites is a responsive Cebu food guide built with Blazor. It introduces local dishes, links readers to selected tourism and restaurant sources, and lets visitors collect dishes in a personal food trail for their current visit.

## Features

- Home page featuring Cebu dishes, food destinations, and source-linked restaurant notes.
- Searchable and filterable dish guide with individual detail pages.
- Food trail for saving and removing dishes while exploring.
- Responsive layouts for desktop, tablet, and mobile, with keyboard focus and reduced-motion support.
- Local food photography served from `wwwroot/images`.
- Source links for destination and restaurant information. Venue menus, hours, and prices are not presented as verified live data.

The guide contains six distinct dish entries, including the Carcar variation of lechon. Dish introductions live in `FoodGuideService`; destination and restaurant cards link to external publishers for further reading. The food trail is a checklist of dishes to try. It is held in memory per Blazor Server circuit and clears after a page refresh or a new session.

## Tech stack

- .NET 8 / ASP.NET Core Blazor Web App
- Blazor Interactive Server rendering
- C# with nullable reference types enabled
- Tailwind CSS 4.3, built with the Tailwind CLI
- Node.js and npm for the CSS toolchain

## Prerequisites

Install the .NET 8 SDK, Node.js 20 or newer with npm, and Git. No database, API key, or other secret is required for the current implementation.

## Get started

From the `SugboBites` project directory:

```sh
dotnet restore
npm ci
npm run build:css
dotnet run --launch-profile http
```

Open the URL printed by `dotnet run`. The included `http` launch profile uses `http://localhost:5054`.

To run the app with .NET hot reload while editing:

```sh
dotnet watch --project SugboBites.csproj run --launch-profile http
```

To rebuild the CSS after editing styles or Razor markup:

```sh
npm run build:css
```

For continuous CSS rebuilding, run this in a separate terminal:

```sh
npm run watch:css
```

## Build and tests

Build the .NET application:

```sh
dotnet build
```

There is currently no automated test project in this repository. `dotnet test` therefore has no application test suite to run.

## Configuration

The application loads `appsettings.json` and `appsettings.{Environment}.json`, with environment variables available for local overrides. The current configuration contains no credentials. Files such as `appsettings.Local.json` and `appsettings.Development.local.json` are ignored by Git but are not loaded automatically; register them explicitly with `AddJsonFile` if they are introduced. If development secrets are needed later, configure a User Secrets ID before using .NET User Secrets.

## Routes

| Route | Description |
| --- | --- |
| `/` | Food guide landing page |
| `/explore` | Search and filter Cebu dish entries |
| `/food/{id}` | Dish detail and source links |
| `/trail` | Saved dishes for the current visit |

The former serving-variation URLs `/food/6` and `/food/8` redirect to `/food/5` and `/food/7`. Unknown dish IDs and unknown pages return HTTP 404.

## Project structure

- `Models/Dish.cs`: the dish data contract, with required properties.
- `Services/FoodGuideService.cs`: the shared, read-only catalog, dish lookup, and available preparation filters.
- `Services/FoodTrailState.cs`: a visitor's saved dishes and change notifications, registered as a scoped service.
- `Components/Pages/`: routed pages and their page-specific state.
- `Components/Sections/`: featured dishes, destinations, and dining sections composed by the home page.
- `Components/Shared/`: reusable page metadata, save controls, and the saved-list lifetime notice.
- `Styles/tailwind.input.css`: the source stylesheet. Rebuild `wwwroot/app.css` with `npm run build:css` after changing it.
- `wwwroot/`: food images, the site icon, and browser assets.

## Content and attribution

Dish and destination information is editorial and links to source pages, including the [Cebu Provincial Tourism Office](https://tourism.cebu.gov.ph/), [Carcar City tourism](https://tourism.cebu.gov.ph/explore/carcar-city/), and relevant [MICHELIN Guide Cebu listings](https://guide.michelin.com/ph/en/central-visayas/cebu-city_2340421/restaurants). Restaurant details can change; consult the linked listing or venue before visiting. Photos are local project assets; verify their usage rights before redistributing the site publicly.

