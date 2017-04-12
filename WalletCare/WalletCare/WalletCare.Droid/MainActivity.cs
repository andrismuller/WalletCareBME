using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace WalletCare.Droid
{
	[Activity (Label = "WalletCare.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;
        RecyclerView mRecyclerView;
        RecyclerView.LayoutManager mLayoutManager;
        BudgetItemListAdapter mBudgetItemListAdapter;
        Budget budget;

        protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

            budget = new Budget();
            mBudgetItemListAdapter = new BudgetItemListAdapter(budget.interactions);
            SetContentView(Resource.Layout.Main);

            mLayoutManager = new LinearLayoutManager(this);
            mRecyclerView.SetLayoutManager(layoutManager);

            mRecyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            mRecyclerView.SetAdapter(mBudgetItemListAdapter);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
			};
		}
	}
}


