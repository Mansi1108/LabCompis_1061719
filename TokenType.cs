using System;
using System.Collections.Generic;
using System.Text;

namespace LabCompis
{
    public enum TokenType
    {
        Plus = '+',
        Star = '*',
        Div = '/',
        Minus = '-',
        LParen = '(',
        RParen = ')',
        EOF = (char)0,
        Empty = (char)1,
        Numero = (char)3
    }
}
