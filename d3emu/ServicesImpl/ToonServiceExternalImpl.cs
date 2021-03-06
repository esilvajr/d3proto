namespace d3emu.ServicesImpl
{
    using System;
    using bnet.protocol;
    using bnet.protocol.toon.external;
    using Google.ProtocolBuffers;

    public class ToonServiceExternalImpl : ToonServiceExternal
    {
        public override void ToonList(IRpcController controller, ToonListRequest request, Action<ToonListResponse> done)
        {
            var builder = new ToonListResponse.Builder
                              {

                              };
            //builder.AddToons(EntityId.CreateBuilder().SetHigh(216174302532224051).SetLow(1).Build());
            done(builder.Build());
        }

        public override void SelectToon(IRpcController controller, SelectToonRequest request, Action<SelectToonResponse> done)
        {
            done(new SelectToonResponse.Builder
                     {

                     }.Build());
        }

        public override void CreateToon(IRpcController controller, CreateToonRequest request, Action<CreateToonResponse> done)
        {
            done(new CreateToonResponse.Builder
                     {
                         Toon = new EntityId.Builder
                                    {
                                        High = HighId.Toon,
                                        Low = 2
                                    }.Build()
                     }.Build());
        }

        public override void DeleteToon(IRpcController controller, DeleteToonRequest request, Action<DeleteToonResponse> done)
        {
            throw new NotImplementedException();
        }
    }
}
