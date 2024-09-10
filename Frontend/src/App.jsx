import 'bootstrap/dist/css/bootstrap.min.css'
import './App.css'
import NavbarEdunova from './components/NavBarEdunova'
import { Route, Routes } from 'react-router-dom'
import { RoutesNames } from './constants'
import Pocetna from './pages/Pocetna'
import SmjeroviPregled from './pages/smjerovi/SmjeroviPregled'

function App() {

  //const[x,setX]=useState(0);

  return (
    <>
      <NavbarEdunova />

      <Routes>
        <Route path={RoutesNames.HOME} element={<Pocetna />} />
        <Route path={RoutesNames.SMJER_PREGLED} element={<SmjeroviPregled />} />

      </Routes>


    </>
  )
}

export default App
