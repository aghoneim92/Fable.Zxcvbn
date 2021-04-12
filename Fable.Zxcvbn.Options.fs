// ts2fable 0.7.1
module rec Fable.Zxcvbn.Options

open Fable.Core
open Fable.Zxcvbn.Types

[<Import("ZxcvbnOptions", "@zxcvbn-ts/core")>]
let ZxcvbnOptions : Options = jsNative

[<AllowNullLiteral>]
type IExports =
  abstract Options : OptionsStatic

[<AllowNullLiteral; RequireQualifiedAccessAttribute>]
type Options =
  abstract l33tTable : OptionsL33tTable with get, set
  abstract dictionary : OptionsDictionary with get, set
  abstract rankedDictionaries : RankedDictionaries with get, set
  abstract translations : TranslationKeys with get, set
  abstract graphs : OptionsGraph with get, set

  abstract availableGraphs : ResizeArray<DefaultAdjacencyGraphsKeys> with get, set


  abstract setOptions : options: OptionsType -> unit
  abstract setTranslations : translations: TranslationKeys -> unit
  abstract checkCustomTranslations : translations: TranslationKeys -> bool
  abstract setRankedDictionaries : unit -> unit
  abstract setAdjacencyGraphs : adjacencyGraphs: OptionsGraph -> unit

[<AllowNullLiteral>]
type OptionsStatic =
  [<Emit "new $0($1...)">]
  abstract Create : unit -> Options
