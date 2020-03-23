﻿namespace Cloudtoid.Foid.Routes.Pattern
{
    internal abstract class PatternNodeVisitor
    {
        protected virtual void Visit(PatternNode node)
        {
        }

        protected internal virtual void VisitLeaf(LeafNode node)
        {
        }

        protected internal virtual void VisitMatch(MatchNode node)
        {
            VisitLeaf(node);
        }

        protected internal virtual void VisitVariable(VariableNode node)
        {
            VisitLeaf(node);
        }

        protected internal virtual void VisitSegment(SegmentlNode node)
        {
            VisitLeaf(node);
        }

        protected internal virtual void VisitWildcard(WildcardNode node)
        {
            VisitLeaf(node);
        }

        protected internal virtual void VisitOptional(OptionalNode node)
        {
            Visit(node.Node);
        }

        protected internal virtual void VisitConcat(ConcatNode node)
        {
            Visit(node.Left);
            Visit(node.Right);
        }
    }
}
