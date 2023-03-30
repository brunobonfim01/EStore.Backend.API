using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Enumerators
{
    public enum FlagCard
    {
        [Description("Visa")]
        Visa = 0,
        [Description("MasterCard")]
        MasterCard = 1,
        [Description("Maestro")]
        Maestro = 2,
        [Description("Elo")]
        Elo = 3,
        [Description("AmericanExpress")]
        AmericanExpress = 4,
        [Description("HiperCard")]
        HiperCard = 5,
        [Description("DinersClub")]
        DinersClub = 6,
        [Description("Discover")]
        Discover = 7,
        [Description("Aura")]
        Aura = 8,
        [Description("JCB")]
        JCB = 9,
        [Description("PagSeguro")]
        PagSeguro = 10,
        [Description("UnionPay")]
        UnionPay = 11,
        [Description("PayPal")]
        PayPal = 12,
        [Description("Amex")]
        Amex = 13,
        [Description("RedeShop")]
        RedeShop = 14,
        [Description("Ticket")]
        Ticket = 15
    }
}
