using System;

namespace mudblazorserver1.Data
{
  public class _RandomService
  {
    public Guid RandomId { get; } = Guid.NewGuid();
  }
}