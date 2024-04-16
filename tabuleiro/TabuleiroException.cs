using System;
using tabuleiro;

namespace tabuleiro {
    class TabuleiroException : Exception {
        public TabuleiroException(string message) : base(message) { }
        public TabuleiroException(string message, Exception innerException) : base(message, innerException) { }
    }
}
