using System;
using System.Collections.Generic;
using System.Text;

namespace LabCompis
{
    class Parser
    {
        Scanner _scanner;
        Token _token;
        public double res = 0;
        private int num = 0;
        private double GP()
        {
            switch (_token.Tag)
            {
                case TokenType.Numero:
                    num = int.Parse(num.ToString() + _token.Value.ToString());
                    Match(TokenType.Numero);
                    return GP();
                default:
                    return num;
            }
        }
        private double G()
        {
            switch (_token.Tag)
            {
                case TokenType.Numero:
                    num = int.Parse(_token.Value.ToString());
                    Match(_token.Tag);
                    return GP();
                case TokenType.LParen:
                    Match(TokenType.LParen);
                    var x = E();
                    Match(TokenType.RParen);
                    return x;
                default:
                    return 0;
            }
        }
        private double F()
        {
            switch (_token.Tag)
            {
                case TokenType.Numero:
                    return G();
                case TokenType.LParen:
                    return G();
                case TokenType.Minus:
                    Match(TokenType.Minus);
                    return -F();
                default:
                    throw new Exception("Error de Sintaxis");
            }
        }
        private double TP()
        {
            switch (_token.Tag)
            {
                case TokenType.Div:
                    Match(TokenType.Div);
                    return 1 / F() * TP();
                case TokenType.Star:
                    Match(TokenType.Star);
                    return F() * TP();
                default:
                    return 1;
            }
        }
        private double T()
        {
            switch (_token.Tag)
            {
                case TokenType.Minus:
                case TokenType.LParen:
                case TokenType.Numero:
                    return F() * TP();
                default:
                    throw new Exception("Error de Sintaxis");
            }
        }
        private double EP()
        {
            switch (_token.Tag)
            {
                case TokenType.Minus:
                    Match(_token.Tag);
                    return -T() + EP();
                case TokenType.Plus:
                    Match(_token.Tag);
                    return T() + EP();
                default:
                    return 0;
            }
        }
        private double E()
        {
            switch (_token.Tag)
            {
                case TokenType.LParen:
                case TokenType.Minus:
                case TokenType.Numero:
                    return T() + EP();
                default:
                    throw new Exception("Error de Sintaxis");
            }//switch
        }

        private void Match(TokenType tag)
        {
            if (_token.Tag == tag)
            {
                _token = _scanner.GetToken();
            }
            else
            {
                throw new Exception("Error de Sintaxis");
            }
        }

        public void Parse(string regexp)
        {
            _scanner = new Scanner(regexp + (char)TokenType.EOF);
            _token = _scanner.GetToken();
            res = E();
            Match(TokenType.EOF);
        }//parse
    }
}
