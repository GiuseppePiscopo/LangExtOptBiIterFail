# LangExtOptBiIterFail
Sample solution showing issue with Language-Ext package and its
`Option<>.BiIter()` method causing a `ValueIsNoneException`.
See [issue ???](https://github.com/louthy/language-ext/issues/???) on project
[home](https://github.com/louthy/language-ext/).

## Steps

1. Restore packages
1. Run from Visual Studio or command line
1. Press a key to actually start processing

See generated exception, wrapped in an *AggregateException* due to `.Wait()`:

**Type:**  
> LanguageExt.ValueIsNoneException

**Message:**  
> Value is none.

**Stacktrace:**  

```
at LanguageExt.OptionData`1.get_Value()
at LanguageExt.Option`1.get_Value()
at LanguageExt.ClassInstances.MOption`1.BiFold[S](Option`1 ma, S state, Func`3 fa, Func`3 fb)
at LanguageExt.TypeClass.biFold[FOLD,F,A,B,S](F foldable, S state, Func`3 fa, Func`3 fb)
at LanguageExt.TypeClass.biIter[FOLD,F,A,B](F foldable, Action`1 fa, Action`1 fb)
at LanguageExt.Option`1.BiIter(Action`1 Some, Action None)
at LangExtOptBiIterFail.Program.<ValidateAsync>d__2.MoveNext() in [...]\Program.cs:line 30
```
