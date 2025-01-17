using AElf.Contracts.Consensus.AEDPoS;
using AElf.Contracts.MultiToken;

namespace Portkey.Contracts.BingoGameContract
{
    public partial class BingoGameContractState
    {
        internal TokenContractContainer.TokenContractReferenceState TokenContract { get; set; }
        internal AEDPoSContractContainer.AEDPoSContractReferenceState ConsensusContract { get; set; }
    }
}