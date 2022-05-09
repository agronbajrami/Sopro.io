import { BrowserRouter as Router, Switch, Route, Link } from "react-router-dom";
import AddGenre from "./components/AddGenre";
import AddMovie from "./components/AddMovie";
import AddPerson from "./components/AddPerson";
import Home from "./components/Home";
import "./styles.css";

export default function App() {
  return (
    <Router>
      <Home />
      <Switch>
        <Route path="/AddGenre">
          <AddGenre />
        </Route>
        <Route path="/AddPerson">
          <AddPerson />
        </Route>
        <Route path="/AddMovie">
          <AddMovie />
        </Route>
      </Switch>
    </Router>
  );
}
