namespace DecoratorPattern.ThirdExample
{
    public abstract class IceCreame
    {
        public abstract string Description { get; }

        public abstract decimal CalcCost();

        public override string ToString()
        {
            return $"{Description} ({CalcCost().ToString("C")})";
        }
    }

    public class BasicIceCreame : IceCreame
    {
        public override string Description => "Ice Cream";

        public override decimal CalcCost() => 3.5m;

        public override string ToString()
        {
            return $"{Description} ({CalcCost().ToString("C")})";
        }
    }

    public abstract class IceCreameDecorator : IceCreame
    {
        protected IceCreame _iceCreame;

        public IceCreameDecorator(IceCreame iceCreame)
        {
            _iceCreame = iceCreame;
        }

        public override string Description => _iceCreame.Description;

        public override decimal CalcCost()
        {
            return _iceCreame.CalcCost();
        }
    }

    public class Sprikels : IceCreameDecorator
    {
        private readonly IceCreame _iceCreame;

        public Sprikels(IceCreame iceCreame) : base(iceCreame)
        {
            _iceCreame = iceCreame;
        }

        public override decimal CalcCost()
        {
            return base.CalcCost() + 1;
        }

        public override string Description => base.Description + $" {GetType().Name}";
    }

    public class Chocolate : IceCreameDecorator
    {
        private readonly IceCreame _iceCreame;

        public Chocolate(IceCreame iceCreame) : base(iceCreame)
        {
            _iceCreame = iceCreame;
        }

        public override decimal CalcCost()
        {
            return base.CalcCost() + 2;
        }

        public override string Description => base.Description + $" {GetType().Name}";
    }

    public class Froute : IceCreameDecorator
    {
        private readonly IceCreame _iceCreame;

        public Froute(IceCreame iceCreame) : base(iceCreame)
        {
            _iceCreame = iceCreame;
        }

        public override decimal CalcCost()
        {
            return base.CalcCost() + 3;
        }

        public override string Description => base.Description + $" {GetType().Name}";
    }
}

/*

 namespace DecoratorPattern.ThirdExample
{
    public abstract class IceCreame
    {
        public abstract string Description { get; }

        public abstract decimal CalcCost();

        public override string ToString()
        {
            return $"{Description} ({CalcCost().ToString("C")})";
        }
    }

    public class BasicIceCreame : IceCreame
    {
        public override string Description => "Ice Cream";

        public override decimal CalcCost() => 3.5m;

        public override string ToString()
        {
            return $"{Description} ({CalcCost().ToString("C")})";
        }
    }

    public class Sprikels : IceCreame
    {
        private readonly IceCreame _iceCreame;

        public Sprikels(IceCreame iceCreame)
        {
            _iceCreame = iceCreame;
        }

        public override decimal CalcCost()
        {
            return _iceCreame.CalcCost() + 1;
        }

        public override string Description => _iceCreame.Description + $" {GetType().Name}";
    }

    public class Chocolate : IceCreame
    {
        private readonly IceCreame _iceCreame;

        public Chocolate(IceCreame iceCreame)
        {
            _iceCreame = iceCreame;
        }

        public override decimal CalcCost()
        {
            return _iceCreame.CalcCost() + 2;
        }

        public override string Description => _iceCreame.Description + $" {GetType().Name}";
    }

    public class Froute : IceCreame
    {
        private readonly IceCreame _iceCreame;

        public Froute(IceCreame iceCreame)
        {
            _iceCreame = iceCreame;
        }

        public override decimal CalcCost()
        {
            return _iceCreame.CalcCost() + 3;
        }

        public override string Description => _iceCreame.Description + $" {GetType().Name}";
    }
}

 */