using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//location is enhanced using this wrapper.
namespace Project2B
{
    interface ILocationEnchancedWrapper : ILocationDecorator
    {
        bool IsDark { get; set; }
        List<IFixture> Fixture { get; }
        void AddFixture(IFixture item);
        bool IsIExit();
        void AddItem(IItem item);
        List<IItem> Items { get; }
        string Description { get; set; }
        void ClearDescription();
        bool HasLightSource { get; }
        bool HasDrawBridge { get; }
        bool HasTrap { get; }
        bool IsOn(IFixture fixture);
        void TurnOnFixture(IFixture val);
        void TurnOffFixture(IFixture val);

    }
}
