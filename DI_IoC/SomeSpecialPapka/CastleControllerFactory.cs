using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.ServiceModel.Channels;
using System.Text;
using System.Web.Mvc;

namespace DI_IoC.SomeSpecialPapka
{
    class CastleControllerFactory: DefaultControllerFactory
    {
        public IWindsorContainer Container { get; protected set; }

        public CastleControllerFactory(IWindsorContainer container)
        {
            this.Container = container ?? 
                throw new ArgumentNullException("null container");
        }

        protected override IController GetControllerInstance(RequestContext reccon, Type controllerType)
        {

        }
    }
}
