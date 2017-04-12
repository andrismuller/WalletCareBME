using System;
using System.Collections.Generic;


using Android.Views;
using Android.Widget;
using Android.Support.V7.Widget;

using BudgetModelPortableLibrary;

namespace WalletCare.Droid.BudgetList
{
    class BudgetItemListAdapter : RecyclerView.Adapter
    {
        public event EventHandler<BudgetItemListAdapterClickEventArgs> ItemClick;
        public event EventHandler<BudgetItemListAdapterClickEventArgs> ItemLongClick;
        List<Interaction> interactions;
        

        public BudgetItemListAdapter(List<Interaction> interactions)
        {
            this.interctions = interactions;
        }

        // Create new views (invoked by the layout manager)
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {

            //Setup your layout here
            View itemView = null;
            var id = Resource.Layout.InteractionLayout;
            itemView = LayoutInflater.From(parent.Context).Inflate(id, parent, false);

            var vh = new BudgetItemViewViewHolder(itemView, OnClick, OnLongClick);
            return vh;
        }

        // Replace the contents of a view (invoked by the layout manager)
        public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
        {
            var item = interactions[position];

            // Replace the contents of the view with that element
            var holder = viewHolder as BudgetItemViewViewHolder;
            if (System.String.Compare(item.Category[0], "Expense") == 0)
            {
                holder.InteractionIconImageView.SetImageResource(Resource.Drawable.ic_attach_money_black_24dp.png);
            }
            else
            {
                holder.InteractionIconImageView.SetImageResource(Resource.Drawable.ic_attach_money_black_24dp.png);
            }
            
            holder.InteractionTimestampTextView.Text = interactions[position].TimeStamp;
            holder.InteractionValueTextView.Text = interactions[position].Value;
            holder.InteractionCategoryTextView.Text = interactions[position].Category;
            holder.InteractionNoteTextView.Text = interactions[position].Note;
            /*holder.InteractionIconImageButton.setImageResource;
            holder.InteractionIconImageButton;
            holder.InteractionIconImageButton;*/
        }

        public override int ItemCount => interactions.Length;

        void OnClick(BudgetItemListAdapterClickEventArgs args) => ItemClick?.Invoke(this, args);
        void OnLongClick(BudgetItemListAdapterClickEventArgs args) => ItemLongClick?.Invoke(this, args);

    }

    public class BudgetItemViewHolder : RecyclerView.ViewHolder
    {
        //public TextView TextView { get; set; }
        public ImageView InteractionIconImageView { get; set; }
        public TextView InteractionTimestampTextView;
        public TextView InteractionValueTextView;
        public TextView InteractionCategoryTextView;
        public TextView InteractionNoteTextView;
        public ImageButton InteractionIconImageButton { get; set; }
        public ImageButton InteractionIconImageButton { get; set; }
        public ImageButton InteractionIconImageButton { get; set; }
        int position;

        public BudgetItemViewHolder(View itemView, Action<Adapter1ClickEventArgs> clickListener,
                            Action<Adapter1ClickEventArgs> longClickListener) : base(itemView)
        {
            InteractionIconImageView = (ImageView)itemView.FindViewById(Resource.Id.InteractionIconImageView);
            InteractionTimestampTextView = (TextView)itemView.FindViewById(Resource.Id.InteractionTimestampTextView);
            InteractionValueTextView = (TextView)itemView.FindViewById(Resource.Id.InteractionValueTextView);
            InteractionCategoryTextView = (TextView)itemView.FindViewById(Resource.Id.InteractionCategoryTextView);
            InteractionNoteTextView = (TextView)itemView.FindViewById(Resource.Id.InteractionNoteTextView);
            InteractionViewImageImageButton = (ImageButton)itemView.FindViewById(Resource.Id.InteractionViewImageImageButton);
            InteractionEditImageButton = (ImageButton)itemView.FindViewById(Resource.Id.InteractionEditImageButton);
            InteractionDeleteImageButton = (ImageButton)itemView.FindViewById(Resource.Id.InteractionDeleteImageButton);

            itemView.Click += (sender, e) => clickListener(new Adapter1ClickEventArgs { View = itemView, Position = AdapterPosition });
            itemView.LongClick += (sender, e) => longClickListener(new Adapter1ClickEventArgs { View = itemView, Position = AdapterPosition });
        }
    }

    public class BudgetItemClickEventArgs : EventArgs
    {
        public View View { get; set; }
        public int Position { get; set; }
    }
}