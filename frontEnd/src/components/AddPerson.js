import { useState } from "react";

const AddPerson = () => {
  const [username, setUsername] = useState("");
  const [userRole, setUserRole] = useState(1);

  const usernameHandler = (event) => {
    setUsername(event.target.value);
  };

  const userRoleHandler = (event) => {
    setUserRole(event.target.value);
  };

  const submitHandler = (event) => {
    event.preventDefault();

    console.log(username);
    console.log(userRole);
    // POST REQUEST -> ADD PERSON
    fetch("https://localhost:7146/api/Person", {
      method: "POST",
      headers: {
        "Content-Type": "application/json"
      },
      body: JSON.stringify({
        name: username,
        userRole: userRole
      })
    })
      .then((response) => {
        console.log(response);
      })
      .catch((err) => {
        console.log(err);
      });
  };

  return (
    <form onSubmit={submitHandler}>
      <div>
        <label htmlFor="username">User Name:</label>
        <input
          type="text"
          id="username"
          value={username}
          onChange={usernameHandler}
        />
      </div>
      <div>
        <label htmlFor="userRole">User Role:</label>
        <input
          type="number"
          id="userRole"
          min="1"
          max="4"
          value={userRole}
          onChange={userRoleHandler}
        />
      </div>
      <button>Add</button>
    </form>
  );
};

export default AddPerson;
