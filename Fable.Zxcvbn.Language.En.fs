// ts2fable 0.7.1
module rec Fable.Zxcvbn.Language.En

open Fable.Core

[<ImportDefault("@zxcvbn-ts/language-en")>]
let zxcvbnEnPackage : _default = jsNative

[<AllowNullLiteral>]
type _defaultDictionary =
  abstract userInputs : ResizeArray<string> with get, set
  abstract commonWords : ResizeArray<string> with get, set
  abstract firstnames : ResizeArray<string> with get, set
  abstract lastnames : ResizeArray<string> with get, set
  abstract wikipedia : ResizeArray<string> with get, set

[<AllowNullLiteral>]
type _defaultTranslationsWarnings =
  abstract straightRow : string with get, set
  abstract keyPattern : string with get, set
  abstract simpleRepeat : string with get, set
  abstract extendedRepeat : string with get, set
  abstract sequences : string with get, set
  abstract recentYears : string with get, set
  abstract dates : string with get, set
  abstract topTen : string with get, set
  abstract topHundred : string with get, set
  abstract common : string with get, set
  abstract similarToCommon : string with get, set
  abstract wordByItself : string with get, set
  abstract namesByThemselves : string with get, set
  abstract commonNames : string with get, set

[<AllowNullLiteral>]
type _defaultTranslationsSuggestions =
  abstract l33t : string with get, set
  abstract reverseWords : string with get, set
  abstract allUppercase : string with get, set
  abstract capitalization : string with get, set
  abstract dates : string with get, set
  abstract recentYears : string with get, set
  abstract associatedYears : string with get, set
  abstract sequences : string with get, set
  abstract repeated : string with get, set
  abstract longerKeyboardPattern : string with get, set
  abstract anotherWord : string with get, set
  abstract useWords : string with get, set
  abstract noNeed : string with get, set

[<AllowNullLiteral>]
type _defaultTranslationsTimeEstimation =
  abstract ltSecond : string with get, set
  abstract second : string with get, set
  abstract seconds : string with get, set
  abstract minute : string with get, set
  abstract minutes : string with get, set
  abstract hour : string with get, set
  abstract hours : string with get, set
  abstract day : string with get, set
  abstract days : string with get, set
  abstract month : string with get, set
  abstract months : string with get, set
  abstract year : string with get, set
  abstract years : string with get, set
  abstract centuries : string with get, set

[<AllowNullLiteral>]
type _defaultTranslations =
  abstract warnings : _defaultTranslationsWarnings with get, set
  abstract suggestions : _defaultTranslationsSuggestions with get, set
  abstract timeEstimation : _defaultTranslationsTimeEstimation with get, set

[<AllowNullLiteral>]
type _default =
  abstract dictionary : _defaultDictionary with get, set
  abstract translations : _defaultTranslations with get, set
