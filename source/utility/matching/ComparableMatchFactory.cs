using System;

namespace code.utility.matching
{
    public class ComparableMatchFactory<Item, Property> where Property : IComparable<Property>
    {
        IGetTheValueOfAProperty<Item, Property> accessor;

        public ComparableMatchFactory(IGetTheValueOfAProperty<Item, Property> accessor)
        {
            this.accessor = accessor;
        }

        public Criteria<Item> greater_than(Property value)
        {
            return x => accessor(x).CompareTo(value) > 0;
        }

        public Criteria<Item> less_than(Property value)
        {
            return x => accessor(x).CompareTo(value) < 0;
        }

        public Criteria<Item> equal_to(Property value)
        {
            return x => accessor(x).CompareTo(value) == 0;
        }

        public Criteria<Item> not_equal_to(Property value)
        {
            return x => accessor(x).CompareTo(value) != 0;
        }
    }
}