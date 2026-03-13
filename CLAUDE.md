# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [HeyGen](https://www.heygen.com/) AI video generation platform, auto-generated from the HeyGen OpenAPI specification using [AutoSDK](https://github.com/HavenDV/AutoSDK). Published as a NuGet package under the `tryAGI` organization.

## Build Commands

```bash
# Build the solution
dotnet build HeyGen.slnx

# Build for release (also produces NuGet package)
dotnet build HeyGen.slnx -c Release

# Run integration tests (requires HEYGEN_API_KEY env var)
dotnet test src/tests/IntegrationTests/HeyGen.IntegrationTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/HeyGen && ./generate.sh
```

## Architecture

### Code Generation Pipeline

The SDK code is **entirely auto-generated** — do not manually edit files in `src/libs/HeyGen/Generated/`.

1. `src/libs/HeyGen/openapi.yaml` — the HeyGen OpenAPI spec (fetched from upstream)
2. `src/helpers/FixOpenApiSpec/` — converts OpenAPI 3.1 → 3.0 format for compatibility
3. `src/libs/HeyGen/generate.sh` — orchestrates: download spec → fix spec → run AutoSDK CLI → output to `Generated/`
4. CI auto-updates the spec every 3 hours and creates PRs if changes are detected

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/HeyGen/` | Main SDK library (`HeyGenApi`) |
| `src/tests/IntegrationTests/` | Integration tests against real HeyGen API |
| `src/helpers/FixOpenApiSpec/` | OpenAPI spec fixer tool |
| `src/helpers/GenerateDocs/` | Documentation generator from integration tests |
| `src/helpers/TrimmingHelper/` | NativeAOT/trimming compatibility validator |

### Build Configuration

- **Target:** `net10.0` (single target)
- **Language:** C# 13 preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + FluentAssertions

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
