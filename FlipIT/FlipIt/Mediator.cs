using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipIt
{
    public sealed class Mediator
    {
        private static readonly Mediator _Instance = new Mediator();
        private Mediator() {}
        public static Mediator GetInstance()
        {
            return _Instance;
        }

        // instance func
        public EventHandler<ButtonPressedEventArgs> ButtonPressed;
        public void OnButtonPressed(object sender, ButtonToChoose button)
        {
            var buttonPressedDelegate = ButtonPressed as EventHandler<ButtonPressedEventArgs>;
            if(buttonPressedDelegate != null)
            {
                buttonPressedDelegate(sender, new ButtonPressedEventArgs { Button = button});
            }
        }
    }
}
