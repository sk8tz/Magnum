namespace Magnum.ProtocolBuffers.Internal
{
    using System;

    public interface IMapping
    {
        void Visit(IMappingVisitor visitor);
        Type TypeMapped { get; }
    }
}