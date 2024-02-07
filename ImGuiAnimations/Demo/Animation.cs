using System.Numerics;

namespace ImGuiAnimations.Demo;

public interface IParticle
{
    void Render();
    void Update();
}

public class Particle : IParticle
{
    public Vector3 Position { get; set; }
    public Vector3 Velocity { get; set; }

    public void Render()
    {
    }

    public void Update()
    {
    }
}
public interface IAnimation<T> where T : IParticle
{
    void Start(List<T> particles);
    void Update(List<T> particles);
    void Stop(List<T> particles);
}

public class ParticleAnimation : IAnimation<Particle>
{
    public void Start(List<Particle> particles)
    {
        
    }

    public void Update(List<Particle> particles)
    {
        
    }

    public void Stop(List<Particle> particles)
    {
       
    }
}