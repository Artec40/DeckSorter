using System;
using System.Collections.Generic;
using System.Text;

namespace DeckSorter
{
    /// <summary>
    /// Интерфейс, предоставляющий свойства хранилища карт и колод.
    /// </summary>
    interface ICardRepository
    {
        string[] SuitsRepository { get; }
        string[] RanksRepository { get; }
    }
}
