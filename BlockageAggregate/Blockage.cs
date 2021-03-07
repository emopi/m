using Arkas.Domain.Core;
using Arkas.Domain.Core.Attributes;

namespace Arma.Services.MasterData.Domain.AggregatesModel.Crm.BlockageAggregate
{
    [EntityDescription("MasterData", "Blockage")]
    public class Blockage : AggregateRoot
    {
        public string Name { get; private set; }

        public Blockage()
        {
        }

        public Blockage(string name)
        {
            Name = name;
        }
    }
}