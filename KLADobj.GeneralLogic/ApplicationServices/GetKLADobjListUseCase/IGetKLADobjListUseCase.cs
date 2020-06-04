using System;
using System.Collections.Generic;
using System.Text;
using KLADobj.ApplicationServices.Interfaces;

namespace KLADobj.ApplicationServices.GetObjectStatusListUseCase
{
    public interface IGetKLADobjListUseCase 
        : IUseCase<GetKLADobjListUseCaseRequest, GetKLADobjListUseCaseResponse>
    {
    }
}
