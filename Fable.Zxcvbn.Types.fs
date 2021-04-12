// ts2fable 0.7.1
module rec Fable.Zxcvbn.Types

open Fable.Core

type DefaultAdjacencyGraphsKeys = obj

type DefaultAdjacencyGraphs = obj

type TranslationKeys = obj

type L33tTableDefault = obj

[<AllowNullLiteral>]
type LooseObject =
  [<Emit "$0[$1]{{=$2}}">]
  abstract Item : key: string -> obj option with get, set

[<StringEnum>]
[<RequireQualifiedAccess>]
type Pattern =
  | Dictionary
  | Regex
  | Repeat
  | Bruteforce
  | Sequence
  | Spatial
  | Date

[<StringEnum>]
[<RequireQualifiedAccess>]
type DictionaryNames =
  | Passwords
  | CommonWords
  | Firstnames
  | Lastnames
  | Wikipedia
  | UserInputs

[<AllowNullLiteral>]
type Match =
  abstract pattern : Pattern with get, set
  abstract i : float with get, set
  abstract j : float with get, set
  abstract token : string with get, set

[<AllowNullLiteral>]
type ExtendedMatch =
  abstract pattern : Pattern with get, set
  abstract i : float with get, set
  abstract j : float with get, set
  abstract token : string with get, set
  abstract matchedWord : string with get, set
  abstract rank : float with get, set
  abstract dictionaryName : DictionaryNames with get, set
  abstract reversed : bool with get, set
  abstract l33t : bool with get, set
  abstract baseGuesses : float with get, set
  abstract uppercaseVariations : float with get, set
  abstract l33tVariations : float with get, set
  abstract guesses : float with get, set
  abstract guessesLog10 : float with get, set
  abstract turns : float with get, set
  abstract baseToken : U2<ResizeArray<string>, string> with get, set
  abstract sub : LooseObject option with get, set
  abstract subDisplay : string option with get, set
  abstract sequenceName : ExtendedMatchSequenceName option with get, set
  abstract sequenceSpace : float option with get, set
  abstract ascending : bool option with get, set
  abstract regexName : ExtendedMatchRegexName option with get, set
  abstract shiftedCount : float option with get, set
  abstract graph : DefaultAdjacencyGraphsKeys option with get, set
  abstract repeatCount : float option with get, set
  abstract regexMatch : ResizeArray<string> option with get, set
  abstract year : float with get, set
  abstract month : float with get, set
  abstract day : float with get, set
  abstract separator : string option with get, set

[<AllowNullLiteral>]
type Optimal =
  abstract m : Match with get, set
  abstract pi : Match with get, set
  abstract g : Match with get, set

[<AllowNullLiteral>]
type CrackTimesSeconds =
  abstract onlineThrottling100PerHour : float with get, set
  abstract onlineNoThrottling10PerSecond : float with get, set
  abstract offlineSlowHashing1e4PerSecond : float with get, set
  abstract offlineFastHashing1e10PerSecond : float with get, set

[<AllowNullLiteral>]
type CrackTimesDisplay =
  abstract onlineThrottling100PerHour : string with get, set
  abstract onlineNoThrottling10PerSecond : string with get, set
  abstract offlineSlowHashing1e4PerSecond : string with get, set
  abstract offlineFastHashing1e10PerSecond : string with get, set

[<AllowNullLiteral>]
type FeedbackType =
  abstract warning : string with get, set
  abstract suggestions : ResizeArray<string> with get, set

[<StringEnum>]
[<RequireQualifiedAccess>]
type MatchingMatcherParams =
  | UserInputs
  | Dictionary
  | L33tTable
  | Graphs

[<StringEnum>]
[<RequireQualifiedAccess>]
type MatchingMatcherNames =
  | Dictionary
  | DictionaryReverse
  | L33t
  | Spatial
  | Repeat
  | Sequence
  | Regex
  | Date

type OptionsL33tTable = U2<L33tTableDefault, ResizeArray<string>>

[<AllowNullLiteral>]
type OptionsDictionary =
  [<Emit "$0[$1]{{=$2}}">]
  abstract Item : key: string -> U2<ResizeArray<string>, ResizeArray<float>> with get, set





type OptionsGraph = U2<DefaultAdjacencyGraphs, OptionsGraphItem>

[<AllowNullLiteral>]
type OptionsType =
  abstract translations : TranslationKeys option with get, set
  abstract graphs : OptionsGraph option with get, set
  abstract l33tTable : OptionsL33tTable option with get, set
  abstract dictionary : OptionsDictionary option with get, set

[<AllowNullLiteral>]
type RankedDictionaries =
  [<Emit "$0[$1]{{=$2}}">]
  abstract Item : key: string -> RankedDictionariesItem with get, set

[<StringEnum>]
[<RequireQualifiedAccess>]
type ExtendedMatchSequenceName =
  | Lower
  | Digits

[<StringEnum>]
[<RequireQualifiedAccess>]
type ExtendedMatchRegexName =
  | RecentYear
  | AlphaLower
  | AlphaUpper
  | Alpha
  | Alphanumeric
  | Digits
  | Symbols

[<AllowNullLiteral>]
type OptionsGraphItem =
  [<Emit "$0[$1]{{=$2}}">]
  abstract Item : key: string -> ResizeArray<string> with get, set

[<AllowNullLiteral>]
type RankedDictionariesItem =
  [<Emit "$0[$1]{{=$2}}">]
  abstract Item : key: string -> float with get, set
