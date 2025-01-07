# Changelog
All notable changes to this shared code project will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/en/1.0.0/)
and this project adheres to [Semantic Versioning](http://semver.org/spec/v2.0.0.html).

## [1.1.2] - 2024-10-18

### Added
- Added a DeploymentWindow API allowing easy interaction with the Deployment Window and its operations
  - This API is leveraged by new UIs in the supported packages

### Fixed
- `SetStatusSeverity` was flipping message and detail. 
- Made main operations of Deployment Window publicly available
- Added auxiliary interfaces and classes for CLI interoperability

## [1.0.0] - 2023-03-22
### Added
- Make internal API public.

## [1.0.0-pre.6] - 2023-01-26
### Added
- Validation command can be specified; it will automatically run when
changes to assets or providers are detected. 

## [1.0.0-pre.5] - 2022-11-16
### Added
- New interface ITypedItem to allow deployment items to specify a sub-type for their service assets.
- `DeploymentStatus` has new pre-built statuses such as `DeploymentStatus.UpToDate` to facilitate status updates.

## [1.0.0-pre.3] - 2022-09-07
### This is the first release of *Unity Package com.unity.services.deployment.api*.




