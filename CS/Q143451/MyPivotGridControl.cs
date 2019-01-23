using DevExpress.XtraPivotGrid;
using System.Drawing;

namespace DXSample
{
    public class MyPivotGridControl : PivotGridControl {
        public MyPivotGridControl() : base() { }
        private MyPivotGridControl synchronizedPivot;
        public MyPivotGridControl SynchronizedPivot {
            get { return synchronizedPivot; }
            set {
                synchronizedPivot = value;
                if (synchronizedPivot.SynchronizedPivot == null) {
                    synchronizedPivot.SynchronizedPivot = this;
                    synchronizedPivot.Size = Size;
                }
            }
        }
        protected override void ScrollBarsValueChanged(Point newValue) {
            base.ScrollBarsValueChanged(newValue);
            synchronizedPivot.ScrollBarsValueChangedInternal(newValue);
        }
        private void ScrollBarsValueChangedInternal(Point newValue) {
            base.ScrollBarsValueChanged(newValue);
        }
    }
}