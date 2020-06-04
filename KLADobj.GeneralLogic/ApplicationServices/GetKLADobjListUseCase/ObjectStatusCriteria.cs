using KLADobj.DomainObjects;
using KLADobj.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KLADobj.ApplicationServices.GetObjectStatusListUseCase
{
    public class ObjectStatusCriteria : ICriteria<kladobj>
    {
        public string ObjectStatus { get; }

        public ObjectStatusCriteria (string objectStatus)
            => ObjectStatus = objectStatus;

        public Expression<Func<kladobj, bool>> Filter
            => (b => b.ObjectStatus == ObjectStatus);
    }
}
