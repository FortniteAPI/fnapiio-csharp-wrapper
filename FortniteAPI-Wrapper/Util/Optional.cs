using System;

namespace FortniteAPI.Util
{
    // https://stackoverflow.com/questions/16199227/optional-return-in-c-net
    public struct Optional<T>
    {
        public bool HasValue { get; private set; }
        private T value;

        public T Value
        {
            get
            {
                if (HasValue)
                {
                    return value;
                }

                throw new InvalidOperationException();
            }
        }

        public Optional(T value)
        {
            this.value = value;
            HasValue = true;
        }

        public static explicit operator T(Optional<T> optional)
        {
            return optional.Value;
        }

        public static implicit operator Optional<T>(T value)
        {
            return new Optional<T>(value);
        }

        public override bool Equals(object obj)
        {
            if (obj is Optional<T> optional)
            {
                return Equals(optional);
            }

            return false;
        }

        public bool Equals(Optional<T> other)
        {
            if (HasValue && other.HasValue)
            {
                return Equals(value, other.value);
            }

            return HasValue == other.HasValue;
        }
    }
}