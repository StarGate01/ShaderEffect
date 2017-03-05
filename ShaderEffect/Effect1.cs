using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace $rootnamespace$
{

    public class $safeitemname$ : ShaderEffect
    {
        
        #region Private fields

        private static PixelShader _pixelShader = new PixelShader();
        private static Uri _bytecodePath = new Uri("$safeitemname$.ps", UriKind.Relative);

        #endregion

        #region Properties

        public static readonly DependencyProperty InputProperty = 
            ShaderEffect.RegisterPixelShaderSamplerProperty("Input", typeof($safeitemname$), 0);
        public Brush Input
        {
            get { return (Brush)GetValue(InputProperty); }
            set { SetValue(InputProperty, value); }
        }

        public static readonly DependencyProperty ColorFilterProperty = 
            DependencyProperty.Register("ColorFilter", typeof(Color), typeof($safeitemname$), 
            new UIPropertyMetadata(Colors.Yellow, PixelShaderConstantCallback(0)));
        public Color ColorFilter
        {
            get { return (Color)GetValue(ColorFilterProperty); }
            set { SetValue(ColorFilterProperty, value); }
        }
        
        #endregion

        #region Constructors

        static $safeitemname$()
        {
            _pixelShader.UriSource = _bytecodePath;
        }

        public $safeitemname$()
        {
            this.PixelShader = _pixelShader;
            UpdateShaderValue(InputProperty);
            UpdateShaderValue(ColorFilterProperty);
        }

        #endregion

    }

}
