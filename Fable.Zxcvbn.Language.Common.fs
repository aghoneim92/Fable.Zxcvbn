// ts2fable 0.7.1
module rec Fable.Zxcvbn.Language.Common

open Fable.Core

[<ImportDefault("@zxcvbn-ts/language-common")>]
let zxcvbnCommonPackage : _default = jsNative

[<AllowNullLiteral>]
type _defaultDictionary =
  abstract userInputs : ResizeArray<string> with get, set
  abstract passwords : ResizeArray<string> with get, set

[<AllowNullLiteral>]
type _default =
  abstract dictionary : _defaultDictionary with get, set
