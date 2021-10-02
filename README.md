# LabCompis_1061719
El ejecutable se encuentra en bin/Debug/netcoreapp3.1

## Gramática
- E -> TE'  
- E'-> +TE' | -TE' | e
- T -> FT'
- T'-> *FT' | /FT' | e
- F -> -F | G
- G -> symbolG' | (E)
- G' -> symbolG' | e

### Análisis
| Regla | First |
| ------ | ------ |
| E -> TE' | First (E) = First(T) = First(F) = First(G) = {-,symbol,(} |
| E'-> +TE' l TE' l e | First (E') = {+,-,e} |
| T -> FT'| First(T) = First(F) = First(G) = {-,symbol,(} |
| T'-> *FT' l /FT' l e | First(T') = {*,/,e} |
| F -> -F l G | First(F) = First(F') = {-,symbol,(} |
| G -> symbolG' l (E) | First(G) = {symbol,(} |
| G' -> symbolG' l e | First(G) = {symbol,(} |
 
 ## Tokens
- Plus = '+'
- Star = '*'
- Div = '/'
- Minus = '-'
- LParen = '('
- RParen = ')'
- EOF = \0
- Numero = 0-9
