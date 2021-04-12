# Fable.Zxcvbn
Fable bindings for the zxcvbn password strength library

# Installation
`dotnet add package Fable.Zxcvbn`
`npm install @zxcvbn-ts/core @zxcvbn-ts/language-common @zxcvbn-ts/language-en`

# Usage

```f#
open Fable.Zxcvbn.Core
open Fable.Zxcvbn.Options
open Fable.Zxcvbn.Language.En
open Fable.Zxcvbn.Language.Common
open Fable.Zxcvbn.Types

let (options: OptionsType) =
    !!{| translations = Some zxcvbnEnPackage.translations
         dictionary =
           Some
             !!{| passwords = zxcvbnCommonPackage.dictionary.passwords
                  userInputs = zxcvbnEnPackage.dictionary.userInputs
                  commonWords = zxcvbnEnPackage.dictionary.commonWords
                  firstnames = zxcvbnEnPackage.dictionary.firstnames
                  lastnames = zxcvbnEnPackage.dictionary.lastnames
                  wikipedia = zxcvbnEnPackage.dictionary.wikipedia |} |}

ZxcvbnOptions.setOptions options
let result = zxcvbn password
```
