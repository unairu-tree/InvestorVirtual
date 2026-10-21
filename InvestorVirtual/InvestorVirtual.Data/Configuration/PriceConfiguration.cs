namespace InvestorVirtual.Data.Configuration;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Models;

public class PriceConfiguration : IEntityTypeConfiguration<Price>
{
    public static readonly IEnumerable<Price> Prices = new List<Price>
    {
        // Price configuration for Nvidia events
        new ()
        {
            Id = 1,
            PriceValue = 136.24m,
            Volume = 185217300,
            EventId = 1
        },
        new ()
        {
            Id = 2,
            PriceValue = 118.42m,
            Volume = 200000000,
            EventId = 2
        },
        new ()
        {
            Id = 3,
            PriceValue = 115.50m,
            Volume = 299686900,
            EventId = 3
        },
        new ()
        {
            Id = 4,
            PriceValue = 132.83m,
            Volume = 187344000,
            EventId = 4
        },
        new ()
        {
            Id = 5,
            PriceValue = 164.10m,
            Volume = 167704100,
            EventId = 5
        },
        new ()
        {
            Id = 6,
            PriceValue = 181.60m,
            Volume = 235518900,
            EventId = 6
        },
        new ()
        {
            Id = 7,
            PriceValue = 185.54m,
            Volume = 157678100,
            EventId = 7
        },
        new ()
        {
            Id = 8,
            PriceValue = 180.64m,
            Volume = 343504800,
            EventId = 8
        },
        new ()
        {
            Id = 9,
            PriceValue = 175.02m,
            Volume = 204274900,
            EventId = 9
        },
        new ()
        {
            Id = 10,
            PriceValue = 187.54m,
            Volume = 97687300,
            EventId = 10
        },

        // Price configuration for Oracle events
        new ()
        {
            Id = 11,
            PriceValue = 172.57m,
            Volume = 30232000,
            EventId = 11
        },
        new ()
        {
            Id = 12,
            PriceValue = 174.16m,
            Volume = 7260900,
            EventId = 12
        },
        new ()
        {
            Id = 13,
            PriceValue = 148.79m,
            Volume = 21486100,
            EventId = 13
        },
        new ()
        {
            Id = 14,
            PriceValue = 127.24m,
            Volume = 11233700,
            EventId = 14
        },
        new ()
        {
            Id = 15,
            PriceValue = 211.10m,
            Volume = 22665300,
            EventId = 15
        },
        new ()
        {
            Id = 16,
            PriceValue = 245.12m,
            Volume = 7149600,
            EventId = 16
        },
        new ()
        {
            Id = 17,
            PriceValue = 307.86m,
            Volume = 69986000,
            EventId = 17
        },
        new ()
        {
            Id = 18,
            PriceValue = 277.18m,
            Volume = 32810700,
            EventId = 18
        },
        new ()
        {
            Id = 19,
            PriceValue = 220.54m,
            Volume = 24711200,
            EventId = 19
        },
        new ()
        {
            Id = 20,
            PriceValue = 195.38m,
            Volume = 14748100,
            EventId = 20
        },

        // Price configuration for Eli Lilly events
        new ()
        {
            Id = 21,
            PriceValue = 842.18m,
            Volume = 4578900,
            EventId = 21
        },
        new ()
        {
            Id = 22,
            PriceValue = 822.51m,
            Volume = 2354900,
            EventId = 22
        },
        new ()
        {
            Id = 23,
            PriceValue = 898.95m,
            Volume = 4374100,
            EventId = 23
        },
        new ()
        {
            Id = 24,
            PriceValue = 812.03m,
            Volume = 2271100,
            EventId = 24
        },
        new ()
        {
            Id = 25,
            PriceValue = 771.75m,
            Volume = 4174100,
            EventId = 25
        },
        new ()
        {
            Id = 26,
            PriceValue = 640.86m,
            Volume = 26101600,
            EventId = 26
        },
        new ()
        {
            Id = 27,
            PriceValue = 764.71m,
            Volume = 3881300,
            EventId = 27
        },
        new ()
        {
            Id = 28,
            PriceValue = 844.50m,
            Volume = 6037200,
            EventId = 28
        },
        new ()
        {
            Id = 29,
            PriceValue = 1059.70m,
            Volume = 4266700,
            EventId = 29
        },
        new ()
        {
            Id = 30,
            PriceValue = 1041.79m,
            Volume = 3726600,
            EventId = 30
        },

        // Price configuration for Micron events
        new ()
        {
            Id = 31,
            PriceValue = 103.19m,
            Volume = 27568100,
            EventId = 31
        },
        new ()
        {
            Id = 32,
            PriceValue = 102.06m,
            Volume = 16633100,
            EventId = 32
        },
        new ()
        {
            Id = 33,
            PriceValue = 96.93m,
            Volume = 28009100,
            EventId = 33
        },
        new ()
        {
            Id = 34,
            PriceValue = 127.25m,
            Volume = 39407000,
            EventId = 34
        },
        new ()
        {
            Id = 35,
            PriceValue = 109.22m,
            Volume = 27917600,
            EventId = 35
        },
        new ()
        {
            Id = 36,
            PriceValue = 161.71m,
            Volume = 57096400,
            EventId = 36
        },
        new ()
        {
            Id = 37,
            PriceValue = 221.91m,
            Volume = 14957500,
            EventId = 37
        },
        new ()
        {
            Id = 38,
            PriceValue = 228.50m,
            Volume = 33843900,
            EventId = 38
        },
        new ()
        {
            Id = 39,
            PriceValue = 225.52m,
            Volume = 41957100,
            EventId = 39
        },
        new ()
        {
            Id = 40,
            PriceValue = 294.37m,
            Volume = 26642900,
            EventId = 40
        },

        // Price configuration for Exxonmobil events
        new ()
        {
            Id = 41,
            PriceValue = 106.83m,
            Volume = 20376500,
            EventId = 41
        },
        new ()
        {
            Id = 42,
            PriceValue = 115.41m,
            Volume = 17315000,
            EventId = 42
        },
        new ()
        {
            Id = 43,
            PriceValue = 105.63m,
            Volume = 20379300,
            EventId = 43
        },
        new ()
        {
            Id = 44,
            PriceValue = 107.22m,
            Volume = 17634800,
            EventId = 44
        },
        new ()
        {
            Id = 45,
            PriceValue = 111.90m,
            Volume = 12996900,
            EventId = 45
        },
        new ()
        {
            Id = 46,
            PriceValue = 114.68m,
            Volume = 17208000,
            EventId = 46
        },
        new ()
        {
            Id = 47,
            PriceValue = 114.36m,
            Volume = 20213400,
            EventId = 47
        },
        new ()
        {
            Id = 48,
            PriceValue = 117.35m,
            Volume = 15919200,
            EventId = 48
        },
        new ()
        {
            Id = 49,
            PriceValue = 119.54m,
            Volume = 19845200,
            EventId = 49
        },
        new ()
        {
            Id = 50,
            PriceValue = 120.53m,
            Volume = 14782500,
            EventId = 50
        },

        // Price configuration for Tesla events
        new ()
        {
            Id = 51,
            PriceValue = 379.28m,
            Volume = 109710700,
            EventId = 51
        },
        new ()
        {
            Id = 52,
            PriceValue = 290.80m,
            Volume = 100118300,
            EventId = 52
        },
        new ()
        {
            Id = 53,
            PriceValue = 282.76m,
            Volume = 212787800,
            EventId = 53
        },
        new ()
        {
            Id = 54,
            PriceValue = 347.68m,
            Volume = 136997300,
            EventId = 54
        },
        new ()
        {
            Id = 55,
            PriceValue = 315.65m,
            Volume = 119483700,
            EventId = 55
        },
        new ()
        {
            Id = 56,
            PriceValue = 323.90m,
            Volume = 77481800,
            EventId = 56
        },
        new ()
        {
            Id = 57,
            PriceValue = 438.97m,
            Volume = 84023500,
            EventId = 57
        },
        new ()
        {
            Id = 58,
            PriceValue = 430.60m,
            Volume = 58513500,
            EventId = 58
        },
        new ()
        {
            Id = 59,
            PriceValue = 446.74m,
            Volume = 87483000,
            EventId = 59
        },
        new ()
        {
            Id = 60,
            PriceValue = 459.64m,
            Volume = 66263000,
            EventId = 60
        },

        // Price configuration for Rocket Lab events
        new ()
        {
            Id = 61,
            PriceValue = 21.25m,
            Volume = 16325100,
            EventId = 61
        },
        new ()
        {
            Id = 62,
            PriceValue = 18.78m,
            Volume = 12096300,
            EventId = 62
        },
        new ()
        {
            Id = 63,
            PriceValue = 22.29m,
            Volume = 7727300,
            EventId = 63
        },
        new ()
        {
            Id = 64,
            PriceValue = 27.85m,
            Volume = 18457700,
            EventId = 64
        },
        new ()
        {
            Id = 65,
            PriceValue = 47.69m,
            Volume = 26692300,
            EventId = 65
        },
        new ()
        {
            Id = 66,
            PriceValue = 44.21m,
            Volume = 21522100,
            EventId = 66
        },
        new ()
        {
            Id = 67,
            PriceValue = 48.69m,
            Volume = 30681600,
            EventId = 67
        },
        new ()
        {
            Id = 68,
            PriceValue = 49.97m,
            Volume = 21987100,
            EventId = 68
        },
        new ()
        {
            Id = 69,
            PriceValue = 57.52m,
            Volume = 38839900,
            EventId = 69
        },
        new ()
        {
            Id = 70,
            PriceValue = 70.12m,
            Volume = 18294100,
            EventId = 70
        },

        // Price configuration for Vertiv events
        new ()
        {
            Id = 71,
            PriceValue = 107.84m,
            Volume = 5945000,
            EventId = 71
        },
        new ()
        {
            Id = 72,
            PriceValue = 81.62m,
            Volume = 1895700,
            EventId = 72
        },
        new ()
        {
            Id = 73,
            PriceValue = 78.00m,
            Volume = 24253700,
            EventId = 73
        },
        new ()
        {
            Id = 74,
            PriceValue = 112.85m,
            Volume = 5005700,
            EventId = 74
        },
        new ()
        {
            Id = 75,
            PriceValue = 130.19m,
            Volume = 6072900,
            EventId = 75
        },
        new ()
        {
            Id = 76,
            PriceValue = 136.74m,
            Volume = 12971100,
            EventId = 76
        },
        new ()
        {
            Id = 77,
            PriceValue = 171.59m,
            Volume = 22483700,
            EventId = 77
        },
        new ()
        {
            Id = 78,
            PriceValue = 170.65m,
            Volume = 6070500,
            EventId = 78
        },
        new ()
        {
            Id = 79,
            PriceValue = 181.82m,
            Volume = 5301300,
            EventId = 79
        },
        new ()
        {
            Id = 80,
            PriceValue = 165.62m,
            Volume = 3075200,
            EventId = 80
        },

        // Price configuration for Celsius events
        new ()
        {
            Id = 81,
            PriceValue = 27.21m,
            Volume = 9288900,
            EventId = 81
        },
        new ()
        {
            Id = 82,
            PriceValue = 34.90m,
            Volume = 9496100,
            EventId = 82
        },
        new ()
        {
            Id = 83,
            PriceValue = 35.79m,
            Volume = 6893300,
            EventId = 83
        },
        new ()
        {
            Id = 84,
            PriceValue = 44.07m,
            Volume = 6733300,
            EventId = 84
        },
        new ()
        {
            Id = 85,
            PriceValue = 42.74m,
            Volume = 12816500,
            EventId = 85
        },
        new ()
        {
            Id = 86,
            PriceValue = 56.34m,
            Volume = 4954800,
            EventId = 86
        },
        new ()
        {
            Id = 87,
            PriceValue = 59.92m,
            Volume = 6614700,
            EventId = 87
        },
        new ()
        {
            Id = 88,
            PriceValue = 40.78m,
            Volume = 5327200,
            EventId = 88
        },
        new ()
        {
            Id = 89,
            PriceValue = 44.28m,
            Volume = 4417700,
            EventId = 89
        },
        new ()
        {
            Id = 90,
            PriceValue = 46.44m,
            Volume = 3964900,
            EventId = 90
        },

        // Price configuration for Vanguard ETF events
        new ()
        {
            Id = 91,
            PriceValue = 110.33m,
            Volume = 70543,
            EventId = 91
        },
        new ()
        {
            Id = 92,
            PriceValue = 99.17m,
            Volume = 65788,
            EventId = 92
        },
        new ()
        {
            Id = 93,
            PriceValue = 90.55m,
            Volume = 60384,
            EventId = 93
        },
        new ()
        {
            Id = 94,
            PriceValue = 100.68m,
            Volume = 40398,
            EventId = 94
        },
        new ()
        {
            Id = 95,
            PriceValue = 103.24m,
            Volume = 43012,
            EventId = 95
        },
        new ()
        {
            Id = 96,
            PriceValue = 104.77m,
            Volume = 26286,
            EventId = 96
        },
        new ()
        {
            Id = 97,
            PriceValue = 110.64m,
            Volume = 23937,
            EventId = 97
        },
        new ()
        {
            Id = 98,
            PriceValue = 110.23m,
            Volume = 37378,
            EventId = 98
        },
        new ()
        {
            Id = 99,
            PriceValue = 112.93m,
            Volume = 34374,
            EventId = 99
        },
        new ()
        {
            Id = 100,
            PriceValue = 112.79m,
            Volume = 18407,
            EventId = 100
        }
    };

    public void Configure(EntityTypeBuilder<Price> builder)
    {
        builder.HasData(Prices);
    }
}