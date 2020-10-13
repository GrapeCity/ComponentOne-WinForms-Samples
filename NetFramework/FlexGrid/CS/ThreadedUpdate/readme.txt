ThreadedUpdate
------------------------------------------------------------------------
Update the grid from a different thread.

Controls are not thread-safe. To use their methods and properties from
a different thread, you should use the Control.Invoke method.

This sample shows how that works.