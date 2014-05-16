function OnParticleCollision (other : GameObject){
Debug.Log("HIT");
    var direction : Vector3 = transform.position - other.transform.position;
    rigidbody.AddForce (direction.normalized * 5);
}

//function OnParticleCollision (other : GameObject)
//{
//    var body : Rigidbody = other.rigidbody;
//    if (body) {
//        var direction : Vector3 = other.transform.position - transform.position;
//        direction = direction.normalized;
//        body.AddForce (direction * 5);
//    }
//}