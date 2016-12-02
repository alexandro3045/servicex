using Contracts;
using Infraestrutura;

namespace Mapping
{
    public interface IEntityMapper<TDomainModel, TDataModel, TId>
        where TDomainModel : Entity
        where TDataModel : EntityContracts
        where TId : struct
    {
        //////Domain To Entity
        TDataModel Map(TDomainModel source);
        TDataModel Map(TDomainModel source, TDataModel destination);

        //////Entity To Domain
        TDomainModel Map(TDataModel source);
        TDomainModel Map(TDataModel source, TDomainModel destination);
    }

   
}