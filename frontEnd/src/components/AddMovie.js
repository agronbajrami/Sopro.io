import { useState } from "react";

const AddMovie = () => {
  const [movieName, setMovieName] = useState("");
  const [movieDescription, setMovieDescription] = useState("");
  const [releaseTime, setReleaseTime] = useState("");
  const [lengthInMinutes, setLengthInMinutes] = useState("");
  const [genresList, setGrenresList] = useState([]);

  const movieNameHandler = (event) => {
    setMovieName(event.target.value);
  };

  const genresListHandler = (event) => {
    setGrenresList(event.target.value);
  };

  const movieDescriptionHandler = (event) => {
    setMovieDescription(event.target.value);
  };

  const releaseTimeHandler = (event) => {
    setReleaseTime(event.target.value);
  };

  const lengthInMinutesHandler = (event) => {
    setLengthInMinutes(event.target.value);
  };

  const submitHandler = (event) => {
    event.preventDefault();
  };

  return (
    <form onSubmit={submitHandler}>
      <div>
        <label htmlFor="movieName">Movie Name:</label>
        <input
          type="text"
          id="movieName"
          value={movieName}
          onChange={movieNameHandler}
        />
      </div>

      <div>
        <label htmlFor="movieDescription">Movie Description:</label>
        <input
          type="text"
          id="movieDescription"
          value={movieDescription}
          onChange={movieDescriptionHandler}
        />
      </div>

      <div>
        <label htmlFor="releaseTime">Release Time:</label>
        <input
          type="date"
          id="releaseTime"
          value={releaseTime}
          onChange={releaseTimeHandler}
        />
      </div>

      <div>
        <label htmlFor="lengthInMinutes">Length in Minutes:</label>
        <input
          type="number"
          step="0.1"
          id="lengthInMinutes"
          value={lengthInMinutes}
          onChange={lengthInMinutesHandler}
        />
      </div>

      <div>
        <label htmlFor="genresList">Genre</label>
        <input type="text" id="genresList" />
      </div>

      <button>Add</button>
    </form>
  );
};

export default AddMovie;
