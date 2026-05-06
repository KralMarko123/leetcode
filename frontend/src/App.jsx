import React from 'react';
import { BrowserRouter, Navigate, Route, Routes } from 'react-router-dom';
import { ROUTES } from './constants/ROUTES';
import Home from './pages/Home';
import Details from './pages/Details';

const App = () => {
	const routerBasename = process.env.NODE_ENV === 'production' ? process.env.PUBLIC_URL : '';

	return (
		<BrowserRouter basename={routerBasename}>
			<Routes>
				<Route path={ROUTES.HOME} element={<Home />} />
				<Route path={ROUTES.DETAILS} element={<Details />} />
				<Route path='*' element={<Navigate to={ROUTES.HOME} replace />} />
			</Routes>
		</BrowserRouter>
	);
};

export default App;
