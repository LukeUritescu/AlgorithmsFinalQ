// <auto-generated>
#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.AlgorithmsGrover\",\"Name\":\"SearchForMarkedInput\"},\"Attributes\":[],\"SourceFile\":\"C:/Workspace/Algorithms/Algorithms_Final/AlgorithmsGrover/AlgorithmsGrover/Operations.qs\",\"Position\":{\"Item1\":13,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nQubits\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":39}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" This operation applies Grover's algorithm to search all possible inputs\",\" to an operation to find a particular marked state.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.AlgorithmsGrover\",\"Name\":\"SearchForMarkedInput\"},\"Attributes\":[],\"SourceFile\":\"C:/Workspace/Algorithms/Algorithms_Final/AlgorithmsGrover/AlgorithmsGrover/Operations.qs\",\"Position\":{\"Item1\":13,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Quantum.AlgorithmsGrover\",\"Name\":\"NIterations\"},\"Attributes\":[],\"SourceFile\":\"C:/Workspace/Algorithms/Algorithms_Final/AlgorithmsGrover/AlgorithmsGrover/Operations.qs\",\"Position\":{\"Item1\":32,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nQubits\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":29}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Returns the number of Grover iterations needed to find a single marked\",\" item, given the number of qubits in a register.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.AlgorithmsGrover\",\"Name\":\"NIterations\"},\"Attributes\":[],\"SourceFile\":\"C:/Workspace/Algorithms/Algorithms_Final/AlgorithmsGrover/AlgorithmsGrover/Operations.qs\",\"Position\":{\"Item1\":32,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":21}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.AlgorithmsGrover
{
    [SourceLocation("C:/Workspace/Algorithms/Algorithms_Final/AlgorithmsGrover/AlgorithmsGrover/Operations.qs", OperationFunctor.Body, 14, 33)]
    public partial class SearchForMarkedInput : Operation<Int64, IQArray<Result>>, ICallable
    {
        public SearchForMarkedInput(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SearchForMarkedInput";
        String ICallable.FullName => "Quantum.AlgorithmsGrover.SearchForMarkedInput";
        protected IUnitary<IQArray<Qubit>> AlgorithmsGroverPrepareUniform
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> AlgorithmsGroverReflectAboutMarked
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> AlgorithmsGroverReflectAboutUniform
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumArraysForEach
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumMeasurementMResetZ
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> NIterations
        {
            get;
            set;
        }

        public override Func<Int64, IQArray<Result>> Body => (__in__) =>
        {
            var nQubits = __in__;
#line hidden
            {
#line 15 "C:/Workspace/Algorithms/Algorithms_Final/AlgorithmsGrover/AlgorithmsGrover/Operations.qs"
                var qubits = Allocate.Apply(nQubits);
#line hidden
                System.Runtime.ExceptionServices.ExceptionDispatchInfo __arg1__ = null;
                try
                {
#line 17 "C:/Workspace/Algorithms/Algorithms_Final/AlgorithmsGrover/AlgorithmsGrover/Operations.qs"
                    AlgorithmsGroverPrepareUniform.Apply(qubits);
#line 21 "C:/Workspace/Algorithms/Algorithms_Final/AlgorithmsGrover/AlgorithmsGrover/Operations.qs"
                    foreach (var idxIteration in new QRange(0L, (NIterations.Apply(nQubits) - 1L)))
#line hidden
                    {
#line 22 "C:/Workspace/Algorithms/Algorithms_Final/AlgorithmsGrover/AlgorithmsGrover/Operations.qs"
                        AlgorithmsGroverReflectAboutMarked.Apply(qubits);
#line 23 "C:/Workspace/Algorithms/Algorithms_Final/AlgorithmsGrover/AlgorithmsGrover/Operations.qs"
                        AlgorithmsGroverReflectAboutUniform.Apply(qubits);
                    }

#line 26 "C:/Workspace/Algorithms/Algorithms_Final/AlgorithmsGrover/AlgorithmsGrover/Operations.qs"
                    return MicrosoftQuantumArraysForEach.Apply<IQArray<Result>>((MicrosoftQuantumMeasurementMResetZ, qubits));
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(__arg2__);
                    throw;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        __arg1__.Throw();
                    }

#line hidden
                    Release.Apply(qubits);
                }
            }
        }

        ;
        public override void Init()
        {
            this.AlgorithmsGroverPrepareUniform = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(AlgorithmsGrover.PrepareUniform));
            this.AlgorithmsGroverReflectAboutMarked = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(AlgorithmsGrover.ReflectAboutMarked));
            this.AlgorithmsGroverReflectAboutUniform = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(AlgorithmsGrover.ReflectAboutUniform));
            this.MicrosoftQuantumArraysForEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.ForEach<,>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumMeasurementMResetZ = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Measurement.MResetZ));
            this.NIterations = this.Factory.Get<ICallable<Int64, Int64>>(typeof(NIterations));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(IQArray<Result> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Result>> Run(IOperationFactory __m__, Int64 nQubits)
        {
            return __m__.Run<SearchForMarkedInput, Int64, IQArray<Result>>(nQubits);
        }
    }

    [SourceLocation("C:/Workspace/Algorithms/Algorithms_Final/AlgorithmsGrover/AlgorithmsGrover/Operations.qs", OperationFunctor.Body, 33, -1)]
    public partial class NIterations : Function<Int64, Int64>, ICallable
    {
        public NIterations(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "NIterations";
        String ICallable.FullName => "Quantum.AlgorithmsGrover.NIterations";
        protected ICallable<Int64, Double> MicrosoftQuantumConvertIntAsDouble
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumMathArcSin
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumMathPI
        {
            get;
            set;
        }

        protected ICallable<Double, Int64> MicrosoftQuantumMathRound
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumMathSqrt
        {
            get;
            set;
        }

        public override Func<Int64, Int64> Body => (__in__) =>
        {
            var nQubits = __in__;
#line 34 "C:/Workspace/Algorithms/Algorithms_Final/AlgorithmsGrover/AlgorithmsGrover/Operations.qs"
            var nItems = (1L << (int)nQubits);
#line 36 "C:/Workspace/Algorithms/Algorithms_Final/AlgorithmsGrover/AlgorithmsGrover/Operations.qs"
            var angle = MicrosoftQuantumMathArcSin.Apply((1D / MicrosoftQuantumMathSqrt.Apply(MicrosoftQuantumConvertIntAsDouble.Apply(nItems))));
#line 37 "C:/Workspace/Algorithms/Algorithms_Final/AlgorithmsGrover/AlgorithmsGrover/Operations.qs"
            var nIterations = MicrosoftQuantumMathRound.Apply((((0.25D * MicrosoftQuantumMathPI.Apply(QVoid.Instance)) / angle) - 0.5D));
#line 38 "C:/Workspace/Algorithms/Algorithms_Final/AlgorithmsGrover/AlgorithmsGrover/Operations.qs"
            return nIterations;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertIntAsDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Convert.IntAsDouble));
            this.MicrosoftQuantumMathArcSin = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Math.ArcSin));
            this.MicrosoftQuantumMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Math.PI));
            this.MicrosoftQuantumMathRound = this.Factory.Get<ICallable<Double, Int64>>(typeof(Microsoft.Quantum.Math.Round));
            this.MicrosoftQuantumMathSqrt = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Math.Sqrt));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 nQubits)
        {
            return __m__.Run<NIterations, Int64, Int64>(nQubits);
        }
    }
}