# Changelog

## [0.21.0](https://github.com/Team-BmSDK/BmSDK-AK/compare/v0.19.0...v0.21.0) (2026-09-12)


### Features

* Add TArray.AsSpan() for ref access ([#138](https://github.com/Team-BmSDK/BmSDK-AK/issues/138)) ([cf2dd7c](https://github.com/Team-BmSDK/BmSDK-AK/commit/cf2dd7cc9252ab0b127913b1a323e2fb17485d62))
* Introduce and release an installer .exe for BmSDK ([#145](https://github.com/Team-BmSDK/BmSDK-AK/issues/145)) ([fa41f69](https://github.com/Team-BmSDK/BmSDK-AK/commit/fa41f69c0bbe6f3893e42f14f8749694af59b9df))
* Load DLC bundles on startup ([#136](https://github.com/Team-BmSDK/BmSDK-AK/issues/136)) ([35ba46b](https://github.com/Team-BmSDK/BmSDK-AK/commit/35ba46b46c7ce09e89945a0ac8de31eaf06a9c0c))


### Bug Fixes

* Load .inis from DLC bundles ([#139](https://github.com/Team-BmSDK/BmSDK-AK/issues/139)) ([2ff034e](https://github.com/Team-BmSDK/BmSDK-AK/commit/2ff034e64f36b8b4500d55ca728cb3cb38d8f409))
* Prevent loaded DLC from being cleared by the menu ([#141](https://github.com/Team-BmSDK/BmSDK-AK/issues/141)) ([e4a110b](https://github.com/Team-BmSDK/BmSDK-AK/commit/e4a110ba507f938402b20b389e1ed6cd5fc8502d))


### Miscellaneous Chores

* Sync version with BmSDK-AC ([99654c6](https://github.com/Team-BmSDK/BmSDK-AK/commit/99654c60e5bae8954779ede3b4884439a429d6a5))

## [0.19.0](https://github.com/Team-BmSDK/BmSDK-AK/compare/v0.18.0...v0.19.0) (2026-09-09)


### Features

* Support Steam copies of Arkham City ([#133](https://github.com/Team-BmSDK/BmSDK-AK/issues/133)) ([74048ab](https://github.com/Team-BmSDK/BmSDK-AK/commit/74048ab8aa7d38340451c28ffb1ea3af00d5636a))

## [0.18.0](https://github.com/Team-BmSDK/BmSDK-AK/compare/v0.17.2...v0.18.0) (2026-08-23)


### Features

* Fall back to next known super in case of unknown class ([#131](https://github.com/Team-BmSDK/BmSDK-AK/issues/131)) ([acb7a26](https://github.com/Team-BmSDK/BmSDK-AK/commit/acb7a26e04ea5235c7f7adb3cc421ee21089a72b))
* Support DLC when launched from .exe ([#5](https://github.com/Team-BmSDK/BmSDK-AK/issues/5)) ([afbf42e](https://github.com/Team-BmSDK/BmSDK-AK/commit/afbf42e0df2b2e53d00c41cbf72378547bea9dca))


### Bug Fixes

* Fix scripts not being loaded since host update ([#127](https://github.com/Team-BmSDK/BmSDK-AK/issues/127)) ([5bb7ecb](https://github.com/Team-BmSDK/BmSDK-AK/commit/5bb7ecbe68400c715bb5da0bbf9da6287b7f67ed))

## [0.17.2](https://github.com/Team-BmSDK/BmSDK-AK/compare/v0.17.1...v0.17.2) (2026-07-10)


### Bug Fixes

* Fix scripts not being loaded since host update ([#3](https://github.com/Team-BmSDK/BmSDK-AK/issues/3)) ([ea9a098](https://github.com/Team-BmSDK/BmSDK-AK/commit/ea9a09845d40ca7ba2b603230d32ff9fe9d92de7))
* **input:** Fix OnKeyDown not firing when run through Steam ([#125](https://github.com/Team-BmSDK/BmSDK-AK/issues/125)) ([6f311a0](https://github.com/Team-BmSDK/BmSDK-AK/commit/6f311a02ebcc405e4255bbfef9e40a24698eaf67))

## [0.17.1](https://github.com/Team-BmSDK/BmSDK-AK/compare/v0.17.0...v0.17.1) (2026-07-10)


### Bug Fixes

* **host:** Use hostfxr_initialize_for_dotnet_command_line for self-contained support ([#122](https://github.com/Team-BmSDK/BmSDK-AK/issues/122)) ([8e9129b](https://github.com/Team-BmSDK/BmSDK-AK/commit/8e9129b6c4b55e128e1772449c7ae5d5cd9fef5d))

## [0.17.0](https://github.com/Team-BmSDK/BmSDK-AK/compare/v0.16.0...v0.17.0) (2026-07-09)


### Features

* Drop .NET Runtime dependency ([#120](https://github.com/Team-BmSDK/BmSDK/issues/120)) ([f8594c7](https://github.com/Team-BmSDK/BmSDK/commit/f8594c7d21b39929929213c5730d406d6b585900))
