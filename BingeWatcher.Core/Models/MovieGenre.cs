using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BingeWatcher.Core.Models
{
    public enum MovieGenre
    {
        [Description("Akcja")]
        Action,

        [Description("Przygodowy")]
        Adventure,

        [Description("Komedia")]
        Comedy,

        [Description("Kryminał")]
        Crime,

        [Description("Dramat")]
        Drama,

        [Description("Fantasy")]
        Fantasy,

        [Description("Historyczny")]
        Historical,

        [Description("Horror")]
        Horror,

        [Description("Polityczny")]
        Political,

        [Description("Romans")]
        Romance,

        [Description("Science fiction")]
        ScienceFiction,

        [Description("Dreszczowiec")]
        Thriller,

        [Description("Western")]
        Western
    }
}
