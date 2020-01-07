using System;
using System.Collections.Generic;
using System.Text;

namespace DeckSorter
{
    /// <summary>
    /// Интерфейс, определяющий свойства карты.
    /// </summary>
    interface ICard
    {
        string Suit { get; }
        string Rank { get; }
    }
}
