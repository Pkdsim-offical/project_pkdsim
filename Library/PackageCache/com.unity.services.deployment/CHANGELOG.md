# Changelog
All notable changes to the Deployment package will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/en/1.0.0/)
and this project adheres to [Semantic Versioning](http://semver.org/spec/v2.0.0.html).

## [1.4.1] - 2024-11-25
### Fixed
- Fixed inspector loading for service assets, below Unity 6

## [1.4.0] - 2024-10-18
### Added
- Implementations to the Deployment API DeploymentWindow.
- Can copy text straight from the Deployment details pane.
- View in Deployment Window button in `.ddef` file.

### Fixed
- Fixed issue where the status panel would have an excessively large initial size.
- Fixed issue where relative paths were not supported in the `ExludePaths` of the Deployment Definitions.
- Fixed issue where placeholder text could be seen in an item's status field on tab switch.
- Fixed issue where progress bars could disappear on tab switch.
- Fixed issue where the GUI state of dragline position + pane size is not persisted between window instances and can find itself in an unwanted state upon opening the window.

## [1.3.0] - 2023-12-14
### Added
- Added deployment samples for the following services
  - Economy
  - Cloud Code Scripts & Modules
  - Leaderboards
  - Remote Config

### Fixed
- Fixed a bug where DeploymentItems could be deployed multiple times concurrently

## [1.2.1] - 2023-11-21
### Added
- Improved overall UI performance when using multiple services

## [1.2.0] - 2023-10-19
### Added
- Added new `Type` column in the Deployment window.

## [1.1.0] - 2023-05-31
### Added
- Deployment now uses the main Environment Selector in Project Settings > Services > Environment, which can also be used to define the target runtime environment.
- Added inspector support for deployment definition exclude paths.
- Added support for deployment definition exclude paths in the Deployment window.

## [1.0.1] - 2023-04-27
### Fixed
- Assets not appearing on load in Unity 2022.

## [1.0.0] - 2023-03-22
### Fixed
- Issues with displaying new environments in the Deployment window.

## [1.0.0-pre.7] - 2022-12-07
### Fixed
- Deployment Status being saved across editor sessions
### Added
- New UI additions like status, asset state and checkboxes

## [1.0.0-pre.5] - 2022-10-27

### Fixed
- Rate limiting triggered in some cases

## [1.0.0-pre.4] - 2022-09-27
### This is the first release of *Unity Package com.unity.services.deployment*.
