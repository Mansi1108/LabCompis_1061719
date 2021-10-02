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
| E'-> +TE' "|" E'->-TE' / E'-> e | First (E') = {+,-,e} |
| T -> FT'| First(T) = First(F) = First(G) = {-,symbol,(} |
| OneDrive | [plugins/onedrive/README.md][PlOd] |
| Medium | [plugins/medium/README.md][PlMe] |
| Google Analytics | [plugins/googleanalytics/README.md][PlGa] |
 







T'-> *FT' | /FT' | e
First(T') = {*,/,e}

F -> -F | G
First(F) = First(F') = {-,symbol,(}

G -> symbolG' | (E) 
First(G) = {symbol,(}

G' -> symbolG' | e 
First(G) = {symbol,(}
