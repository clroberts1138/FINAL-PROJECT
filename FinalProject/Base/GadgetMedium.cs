﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniqueNumberGenerators;

namespace FINALPROJECT
{

    public class GadgetMedium : AbstractGadget
    {
        private int _buttons = 3, _switches = 3, _quantity = 1, _lights = 2;
        private int _smallWidgets = 2, _mediumWidgets = 2, _largeWidgets = 1;
        private long _serialNumber = 0;
        private long _upcNumber = 0;
        private GadgetColor _gadgetColor;
        private WidgetColor _widgetColor;
        private GadgetPower _gadgetPower;
        private GadgetType _gadgetType = GadgetType.Retail;
        private GadgetSize _gadgetSize = GadgetSize.Medium;

        public override int Quantity
        {
            set
            {
                this._quantity = Quantity;
            }
            get
            {
                return _quantity;
            }
        }


        public override GadgetColor GadgetColorType
        {
            set
            {
                this._gadgetColor = value;
            }
            get
            {
                return _gadgetColor;
            }
        }

        public override WidgetColor WidgetColorType
        {
            set
            {
                this._widgetColor = value;
            }
            get
            {
                return _widgetColor;
            }
        }
        public override GadgetPower PowerType
        {
            set
            {
                this._gadgetPower = value;
                if (_gadgetPower == GadgetPower.Generator)
                {
                    this._gadgetPower = GadgetPower.Battery;
                }
            }
            get
            {
                return _gadgetPower;
            }
        }

        public override int Switches
        {
            set
            {
                this._switches = value;
            }
            get
            {
                return _switches;
            }
        }

        public override int Buttons
        {
            set
            {
                this._buttons = value;
            }
            get
            {
                return _buttons;
            }
        }

        public override int Lights
        {
            set
            {
                this._lights = value;
            }
            get
            {
                return _lights;
            }
        }

        public override GadgetType GadgetType
        {
            set
            {
                this._gadgetType = value;
            }
            get
            {
                return _gadgetType;
            }
        }

        public override GadgetSize GadgetSize
        {
            get
            {
                return _gadgetSize;
            }
        }

        public override int SmallWidgets
        {
            get
            {
                return _smallWidgets;
            }
        }

        public override int MediumWidgets
        {
            get
            {
                return _mediumWidgets;
            }
        }

        public override int LargeWidgets
        {
            get
            {
                return _largeWidgets;
            }
        }

        public override decimal Price
        {
            get { return 45.00m; }
        }

        public override long SerialNumber
        {
            set
            {
                this._serialNumber = SerialNumber;
            }
            get
            {
                return _serialNumber;
            }
        }

        public override long UpcNumber
        {
            set
            {
                this._upcNumber = value;
            }
            get
            {
                return _upcNumber;
            }
        }

        public GadgetMedium(long SerialNumber, long UPCNumber)
            : this(WidgetColor.Unpainted, GadgetColor.Unpainted, GadgetPower.Battery, SerialNumber, UPCNumber)
        {
            //   Console.WriteLine("This is where we build the Widgets for Medium Gadget");
            List<WidgetSmall> mySmallWidgets = new List<WidgetSmall>();
            for (int i = 0; i < _smallWidgets; i++)
            {
                mySmallWidgets.Add(new WidgetSmall(WidgetColor.Unpainted));
            }

            List<WidgetMedium> myMediumWidgets = new List<WidgetMedium>();
            for (int i = 0; i < _mediumWidgets; i++)
            {
                myMediumWidgets.Add(new WidgetMedium(WidgetColor.Unpainted));
            }

            List<WidgetLarge> myLargeWidgets = new List<WidgetLarge>();
            for (int i = 0; i < _largeWidgets; i++)
            {
                myLargeWidgets.Add(new WidgetLarge(WidgetColor.Unpainted));
            }
            this._serialNumber = SerialNumber;
            this._upcNumber = UPCNumber;
        }

        public GadgetMedium(WidgetColor widgetcolor, GadgetColor gadgetcolor, GadgetPower power, long SerialNumber, long UPCNumber)
            : base(widgetcolor, gadgetcolor, power, SerialNumber, UPCNumber)
        {
            //   Console.WriteLine("This is where we build the Widgets for Medium Gadget");
            List<WidgetSmall> mySmallWidgets = new List<WidgetSmall>();
            for (int i = 0; i < _smallWidgets; i++)
            {
                mySmallWidgets.Add(new WidgetSmall(widgetcolor));
            }

            List<WidgetMedium> myMediumWidgets = new List<WidgetMedium>();
            for (int i = 0; i < _mediumWidgets; i++)
            {
                myMediumWidgets.Add(new WidgetMedium(widgetcolor));
            }

            List<WidgetLarge> myLargeWidgets = new List<WidgetLarge>();
            for (int i = 0; i < _largeWidgets; i++)
            {
                myLargeWidgets.Add(new WidgetLarge(widgetcolor));
            }
            this._gadgetColor = gadgetcolor;
            this._widgetColor = widgetcolor;
            this._upcNumber = UPCNumber;
            this._serialNumber = SerialNumber;
            if (power == GadgetPower.Generator)
            {
                this._gadgetPower = GadgetPower.Battery;
            }
            else
            {
                this._gadgetPower = power;
            }
        }
    }
}
