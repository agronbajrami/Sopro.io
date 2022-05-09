import { Link } from "react-router-dom";

const Home = () => {
  return (
    <div>
      <Link to="/AddGenre">Add Genre</Link> <br />
      <Link to="/AddPerson">Add Person</Link> <br />
      <Link to="/AddMovie">Add Movie</Link>
    </div>
  );
};

export default Home;
