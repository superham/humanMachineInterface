## Recreating the prism adaptation paradigm in an immersive virtual environment

![Research Overview](./images/overview.jpg?raw=true "Research Overview")

Sensorimotor adaptation experiments are widely used to study the learning processes of the brain and to improve motor function for rehabilitation patients. One of the first adaptation experiments was the classical prism adaptation paradigm, which uses physical optics to introduce a visual perturbation and induce motor adaptation. Our research seeks to recreate the prism adaptation paradigm using a modern virtual reality head-mounted display (HMD), the HTC Vive Pro. We developed an application that allows us to measure sensorimotor adaptation in an immersive virtual reality environment and to explore the feasibility of using a consumer-grade HMD as a tool to study characteristics of motor adaptation.


The HMD is tracked by two base stations which allows the subject to move around and interact with a virtual 3D space the size of a room. We programmed a tracked object to act as a throwable ball whose position is aligned in the virtual world and in the physical world. The subjects threw the tracked object at a virtual target 8 ft away, and the object landed in a foam-padded area in the physical world. Two trackers were used: the first tracker was unperturbed and the second tracker had a -30° translation applied to it after being thrown. This perturbation was developed to mimic that of wearing the prism glasses in the classical experiment. We followed a procedure of a series of 20 tosses with unperturbed, 20 tosses perturbed, 20 tosses unperturbed, 20 tosses perturbed, 10 tosses unperturbed, 10 tosses perturbed, 10 tosses unperturbed, and 10 tosses perturbed. We then measured the subjects response to the introduced perturbation by recording the horizontal distance from the target on each throw.


We observed patterns of adaptation that in general are consistent with those we see outside of virtual environments. For example, even with no contextual cues, in immersive virtual reality, subjects adapted more quickly to familiar perturbations--a phenomenon often called savings. The HTC Vive Pro shows promise as a tool to study the various characteristics of motor adaptation, and the programming flexibility of a virtual environment enables a wide range of easily modifiable perturbations and scenarios.

This has been developed using the [Unity Engine](https://unity3d.com/) and [HTC Vive](https://www.vive.com/eu/) with optional [trackers](https://www.vive.com/us/vive-tracker/).


Grants Recieved:
- Nvidia GPU Research Grant
- Valparaiso University Creative Work and Research Grant
