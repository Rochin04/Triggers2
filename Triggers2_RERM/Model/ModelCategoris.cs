using System;
using System.Collections.Generic;
using System.Text;
using Triggers2_RERM.ViewModel;

namespace Triggers2_RERM.Model
{
    public class ModelCategoris:ViewModelBase
    {
        public string description { get; set; }
        public int numberItem { get; set; }
        public string images { get; set; }
        //
        public string _backgroundColor;
        public string _textColor;
        public bool _selected;
        public string backgroundColor
        {
            get { return _backgroundColor; }
            set { SetProperty(ref _backgroundColor, value); }
        }
        public string textColor
        {
            get { return _textColor; }
            set { SetProperty(ref _textColor, value); }
        }
        public bool selected
        {
            get { return _selected; }
            set { SetProperty(ref _selected, value); }
        }
    }
}
