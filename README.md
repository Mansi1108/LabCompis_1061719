# LabCompis_1061719
El ejecutable se encuentra en bin/Debug/netcoreapp3.1
##Gramática
E -> TE'  
E'-> +TE' | -TE' | e
T -> FT'
T'-> *FT' | /FT' | e
F -> -F | G
G -> symbolG' | (E)
G' -> symbolG' | e
