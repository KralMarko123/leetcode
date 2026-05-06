import React from 'react';
import { EASY, HARD, MEDIUM } from '../constants/MISC';
import './layout.css';

const FILTERS = [
	{ label: 'All', value: 'all' },
	{ label: 'Easy', value: EASY },
	{ label: 'Medium', value: MEDIUM },
	{ label: 'Hard', value: HARD }
];

const ProblemFilter = ({ activeDifficulty, counts, handleFilterClick }) => {
	return (
		<div className='problem-filter' role='group' aria-label='Filter solutions by difficulty'>
			{FILTERS.map((filter) => (
				<button
					key={filter.value}
					type='button'
					className={`filter-option ${filter.value}${
						activeDifficulty === filter.value ? ' active' : ''
					}`}
					aria-pressed={activeDifficulty === filter.value}
					onClick={() => handleFilterClick(filter.value)}
				>
					<span>{filter.label}</span>
					<span className='filter-count'>{counts[filter.value] ?? 0}</span>
				</button>
			))}
		</div>
	);
};

export default ProblemFilter;
