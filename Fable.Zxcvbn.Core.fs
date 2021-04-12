// ts2fable 0.7.1
module rec Fable.Zxcvbn.Core

open Fable.Core

[<Import("zxcvbn", "@zxcvbn-ts/core")>]
let zxcvbn : (string -> ZxcvbnResult) = jsNative

[<AllowNullLiteral>]
type ZxcvbnResult =
  abstract feedback : obj with get, set
  abstract crackTimesSeconds : obj with get, set
  abstract crackTimesDisplay : obj with get, set
  abstract score : int with get, set
  abstract password : string with get, set
  abstract guesses : float with get, set
  abstract guessesLog10 : float with get, set
  abstract sequence : ResizeArray<obj> with get, set
  abstract calcTime : float with get, set
