using FurnitureShop3d.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace FurnitureShop3d.Behaviors
{
    public class CarouselViewParallaxBehavior : Behavior<CarouselView>
    {
        public static readonly BindableProperty ParallaxOffsetProperty =
          BindableProperty.Create(nameof(ParallaxOffset), typeof(double), typeof(CarouselViewParallaxBehavior), 200.0d,
              BindingMode.TwoWay, null);

        public double ParallaxOffset
        {
            get { return (double)GetValue(ParallaxOffsetProperty); }
            set { SetValue(ParallaxOffsetProperty, value); }
        }

        protected override void OnAttachedTo(CarouselView bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.Scrolled += OnScrolled;
        }

        protected override void OnDetachingFrom(CarouselView bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.Scrolled -= OnScrolled;
        }

        private void OnScrolled(object sender, ItemsViewScrolledEventArgs e)
        {
            var carousel = (CarouselView)sender;
            var carouselItems = carousel.ItemsSource.Cast<object>().ToList();
            var currentIndex = e.CenterItemIndex;
            var lastIndex = e.LastVisibleItemIndex;
            var layout = carousel.ItemsLayout;
            var adjust = Device.RuntimePlatform == Device.Android ? 2.6 : 1;

            if (layout is LinearItemsLayout linearItemsLayout)
            {
                if (linearItemsLayout.Orientation == ItemsLayoutOrientation.Horizontal)
                {
                    var carouselWidth = carousel.Width;
                    var offset = (carouselWidth * (currentIndex + 1)) - (e.HorizontalOffset / adjust);
                    var position = (offset * ParallaxOffset / carouselWidth) - ParallaxOffset;
                    var scale = offset * 100 / carouselWidth / 100;

                    var lastItem = carouselItems[lastIndex] as ItemsViewModel;
                    lastItem.Position = position + ParallaxOffset;
                    lastItem.Rotation = position / 2;
                    lastItem.Scale = 1 - scale;

                    var currentItem = carouselItems[currentIndex] as ItemsViewModel;
                    currentItem.Position = position;
                    currentItem.Rotation = position;
                    currentItem.Scale = scale;
                }

                if (linearItemsLayout.Orientation == ItemsLayoutOrientation.Vertical)
                {
                    var carouselHeight = carousel.Height;
                    var offset = (carouselHeight * (currentIndex + 1)) - (e.VerticalOffset / adjust);
                    var position = (offset * ParallaxOffset / carouselHeight) - ParallaxOffset;
                    var scale = offset * 100 / carouselHeight / 100;

                    var lastItem = carouselItems[lastIndex] as ItemsViewModel;
                    lastItem.Position = position + ParallaxOffset;
                    lastItem.Rotation = position / 2;
                    lastItem.Scale = 1 - scale;

                    var currentItem = carouselItems[currentIndex] as ItemsViewModel;
                    currentItem.Position = position;
                    currentItem.Rotation = position;
                    currentItem.Scale = scale;
                }
            }
        }
    }
}
