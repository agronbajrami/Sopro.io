import { useState } from "react";

const AddGenre = () => {
  const [genreInput, setGenreInput] = useState("");

  const genreHandler = (event) => {
    setGenreInput(event.target.value);
  };

  const submitHandler = (event) => {
    event.preventDefault();

    console.log(genreInput);
    // POST REQUEST -> ADD GENRE
    fetch("https://localhost:7146/api/Genre", {
      method: "POST",
      headers: {
        "Content-Type": "application/json"
      },
      body: JSON.stringify({
        name: genreInput
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
      <label htmlFor="genre">Genre:</label>
      <input
        type="text"
        id="genre"
        value={genreInput}
        onChange={genreHandler}
      />
      <button>Add</button>
    </form>
  );
};

export default AddGenre;
