// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------

namespace System.IO.Pipelines
{
    public partial struct FlushResult
    {
        private int _dummy;
        public FlushResult(bool isCanceled, bool isCompleted) { throw null; }
        public bool IsCanceled { get { throw null; } }
        public bool IsCompleted { get { throw null; } }
    }
    public partial interface IDuplexPipe
    {
        System.IO.Pipelines.PipeReader Input { get; }
        System.IO.Pipelines.PipeWriter Output { get; }
    }
    public partial interface IPipeAwaiter<out T>
    {
        bool IsCompleted { get; }
        T GetResult();
        void OnCompleted(System.Action continuation);
    }
    public sealed partial class Pipe
    {
        public Pipe() { }
        public Pipe(System.IO.Pipelines.PipeOptions options) { }
        public System.IO.Pipelines.PipeReader Reader { get { throw null; } }
        public System.IO.Pipelines.PipeWriter Writer { get { throw null; } }
        public void Reset() { }
    }
    public partial struct PipeAwaiter<T> : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
    {
        private object _dummy;
        public PipeAwaiter(System.IO.Pipelines.IPipeAwaiter<T> awaiter) { throw null; }
        public bool IsCompleted { get { throw null; } }
        public System.IO.Pipelines.PipeAwaiter<T> GetAwaiter() { throw null; }
        public T GetResult() { throw null; }
        public void OnCompleted(System.Action continuation) { }
        public void UnsafeOnCompleted(System.Action continuation) { }
    }
    public partial class PipeOptions
    {
        public PipeOptions(System.Buffers.MemoryPool<byte> pool = null, System.IO.Pipelines.PipeScheduler readerScheduler = null, System.IO.Pipelines.PipeScheduler writerScheduler = null, long pauseWriterThreshold = (long)0, long resumeWriterThreshold = (long)0, int minimumSegmentSize = 2048) { }
        public static System.IO.Pipelines.PipeOptions Default { get { throw null; } }
        public int MinimumSegmentSize { get { throw null; } }
        public long PauseWriterThreshold { get { throw null; } }
        public System.Buffers.MemoryPool<byte> Pool { get { throw null; } }
        public System.IO.Pipelines.PipeScheduler ReaderScheduler { get { throw null; } }
        public long ResumeWriterThreshold { get { throw null; } }
        public System.IO.Pipelines.PipeScheduler WriterScheduler { get { throw null; } }
    }
    public abstract partial class PipeReader
    {
        protected PipeReader() { }
        public abstract void AdvanceTo(System.SequencePosition consumed);
        public abstract void AdvanceTo(System.SequencePosition consumed, System.SequencePosition examined);
        public abstract void CancelPendingRead();
        public abstract void Complete(System.Exception exception = null);
        public abstract void OnWriterCompleted(System.Action<System.Exception, object> callback, object state);
        public abstract System.IO.Pipelines.PipeAwaiter<System.IO.Pipelines.ReadResult> ReadAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        public abstract bool TryRead(out System.IO.Pipelines.ReadResult result);
    }
    public abstract partial class PipeScheduler
    {
        protected PipeScheduler() { }
        public static System.IO.Pipelines.PipeScheduler Inline { get { throw null; } }
        public static System.IO.Pipelines.PipeScheduler ThreadPool { get { throw null; } }
        public abstract void Schedule(System.Action action);
        public abstract void Schedule(System.Action<object> action, object state);
    }
    public abstract partial class PipeWriter : System.Buffers.IBufferWriter<byte>
    {
        protected PipeWriter() { }
        public abstract void Advance(int bytes);
        public abstract void CancelPendingFlush();
        public abstract void Complete(System.Exception exception = null);
        public abstract System.IO.Pipelines.PipeAwaiter<System.IO.Pipelines.FlushResult> FlushAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        public abstract System.Memory<byte> GetMemory(int minimumLength = 0);
        public abstract System.Span<byte> GetSpan(int minimumLength = 0);
        public abstract int MaxBufferSize { get; }
        public abstract void OnReaderCompleted(System.Action<System.Exception, object> callback, object state);
        public virtual System.IO.Pipelines.PipeAwaiter<System.IO.Pipelines.FlushResult> WriteAsync(System.ReadOnlyMemory<byte> source, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial struct ReadResult
    {
        private object _dummy;
        public ReadResult(System.Buffers.ReadOnlySequence<byte> buffer, bool isCanceled, bool isCompleted) { throw null; }
        public System.Buffers.ReadOnlySequence<byte> Buffer { get { throw null; } }
        public bool IsCanceled { get { throw null; } }
        public bool IsCompleted { get { throw null; } }
    }
}
